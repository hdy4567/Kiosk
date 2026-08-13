using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Kiosk.Controls
{
    public class RoundedButton : Button
    {
        // 필수 속성 필드
        private int _borderRadius = 40;
        private Color _borderColor = Color.FromArgb(255, 192, 128);
        private float _borderSize = 2f;

        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public float BorderSize
        {
            get => _borderSize;
            set { _borderSize = value; Invalidate(); }
        }

        public RoundedButton()
        {
            DoubleBuffered = true;
            Size = new Size(150, 50);
            BackColor = Color.White;
            ForeColor = Color.Black;

            // WinForms 기본 버튼 스타일 비활성화 (커스텀 페인팅 활성화)
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }

        // 모서리 경로 생성 공식 최적화
        private GraphicsPath GetRoundedPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            if (curveSize > rect.Width) curveSize = rect.Width;
            if (curveSize > rect.Height) curveSize = rect.Height;
            if (curveSize <= 0) curveSize = 1;

            path.StartFigure();
            // 상단 좌측
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            // 상단 우측
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            // 하단 우측 (버튼의 자연스러움을 위해 전방향 라운딩 적용, 필요 시 직각 조정 가능)
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            // 하단 좌측
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // base.OnPaint(e)를 호출하면 운영체제 기본 버튼이 그려지므로 호출하지 않고 완전 수동 제어
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectViewport = new RectangleF(0, 0, Width, Height);

            // 펜 정렬(Inset)을 고려하여 테두리가 잘리지 않도록 마진 조정
            float margin = _borderSize / 2f;
            RectangleF rectBorder = new RectangleF(margin, margin, Width - _borderSize, Height - _borderSize);

            if (_borderRadius > 2)
            {
                using (GraphicsPath pathViewport = GetRoundedPath(rectViewport, _borderRadius))
                using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, _borderRadius - margin))
                using (Brush brushBackground = new SolidBrush(BackColor))
                using (Pen penBorder = new Pen(_borderColor, _borderSize))
                {
                    // 버튼 영역 클리핑 (모서리 바깥쪽 제거)
                    Region = new Region(pathViewport);

                    // 1. 배경 채우기
                    g.FillPath(brushBackground, pathViewport);

                    // 2. 테두리 그리기
                    if (_borderSize > 0 && _borderColor != Color.Transparent)
                    {
                        penBorder.Alignment = PenAlignment.Center;
                        g.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                // 라운딩이 없을 경우 일반 사각형 처리
                Region = new Region(rectViewport);
                using (Brush brushBackground = new SolidBrush(BackColor))
                {
                    g.FillRectangle(brushBackground, rectViewport);
                }

                if (_borderSize > 0 && _borderColor != Color.Transparent)
                {
                    using (Pen penBorder = new Pen(_borderColor, _borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        g.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }

            // 3. 버튼 텍스트 정렬 및 그리기
            TextRenderer.DrawText(
                g,
                Text,
                Font,
                ClientRectangle,
                ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis
            );
        }
    }
}
