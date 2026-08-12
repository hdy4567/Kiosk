using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.ComponentModel;

namespace Kiosk
{
    public class RoundToplabel : Label
    {
        public int BorderRadius { get; set; } = 40;

        public RoundToplabel()
        {
            this.AutoSize = false;
            this.BorderRadius = 90;
            this.BackColor = Color.FromArgb(255, 192, 128);
            this.TextAlign = ContentAlignment.MiddleCenter; // 텍스트 중앙 정렬
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.Width <= 0 || this.Height <= 0) return;

            // 크기 초과 방지 안전 로직 (에러 발생 주요 원인 차단)
            int diameter = Math.Min(BorderRadius, Math.Min(this.Width, this.Height));
            if (diameter <= 0) diameter = 1;

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom);
                path.CloseFigure();

                this.Region = new Region(path);
            }

            base.OnPaint(e);
        }
    }
}