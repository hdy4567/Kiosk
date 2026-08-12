using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Kiosk.Controls
{
    public class RoundedPanel : Panel
    {
       private int _borderRadius = 90;
       private int _Bottom_borderRadius = 40;
       private Color _borderColor = Color.Black;
       private float _borderSize = 1;


       private bool _showShadow = true;
       private int _shadowDepth = 8;
       private Color _shadowColor = Color.FromArgb(60, 0, 0, 0);
       public int BorderRadius
       {
           get => _borderRadius;
           set { _borderRadius = value; Invalidate(); }

       }

       public int BottomBorderRadius
       {
           get => _Bottom_borderRadius;
           set { _Bottom_borderRadius = value; Invalidate(); }
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

        private BorderStyle _borderStyle = BorderStyle.None;

        public new BorderStyle BorderStyle
        {
            get => _borderStyle;
            set
            {
                _borderStyle = value;
                if (_borderStyle == BorderStyle.FixedSingle)
                {
                    _borderSize = 1;
                    if (_borderColor == Color.Transparent)
                    {
                        _borderColor = Color.Black;
                    }
                }
                else if (_borderStyle == BorderStyle.None)
                {
                    _borderSize = 0;
                }
                Invalidate();
            }
        }



       public bool ShowShadow
       {
           get => _showShadow;
           set { _showShadow = value; Invalidate(); }

       }

       public int ShadowDepth
       {
           get => _shadowDepth;
           set { _shadowDepth = value; Invalidate(); }

       }

       public Color ShadowColor
       {
           get => _shadowColor;
           set { _shadowColor = value; Invalidate(); }
       }

       private bool _roundTopLeft = true;
       private bool _roundTopRight = true;

       public bool RoundTopLeft
       {
           get => _roundTopLeft;
           set
           {
               _roundTopLeft = value;
               Invalidate();
           }
       }

       public bool RoundTopRight
       {
           get => _roundTopRight;
           set
           {
               _roundTopRight = value;
               Invalidate();
           }
       }

       public bool RoundBottomRight { get; set; } = true;
       public bool RoundBottomLeft { get; set; } = true;

       public RoundedPanel()
       {
           DoubleBuffered = true;
           base.BorderStyle = BorderStyle.None;
       }

        private GraphicsPath GetRoundedPath(RectangleF rect, float radius, float bottomRadius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            // Ensure the curve size doesn't exceed the bounds of the rectangle
            if (curveSize > rect.Width) curveSize = rect.Width;
            if (curveSize > rect.Height) curveSize = rect.Height;
            if (curveSize <= 0) curveSize = 1;

            path.StartFigure();

            // Top-Left corner
            if (_roundTopLeft)
            {
                path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            }
            else
            {
                path.AddLine(rect.X, rect.Y, rect.X, rect.Y);
            }

            // Top-Right corner
            if (_roundTopRight)
            {
                path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            }
            else
            {
                path.AddLine(rect.Right, rect.Y, rect.Right, rect.Y);
            }

            float bottomCurveSize = bottomRadius * 2F;
            if (bottomCurveSize > rect.Width) bottomCurveSize = rect.Width;
            if (bottomCurveSize > rect.Height) bottomCurveSize = rect.Height;
            if (bottomCurveSize <= 0) bottomCurveSize = 1;

            // Bottom-Right corner
            if (RoundBottomRight && bottomRadius > 0)
            {
                path.AddArc(rect.Right - bottomCurveSize, rect.Bottom - bottomCurveSize, bottomCurveSize, bottomCurveSize, 0, 90);
            }
            else
            {
                path.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Bottom);
            }

            // Bottom-Left corner
            if (RoundBottomLeft && bottomRadius > 0)
            {
                path.AddArc(rect.X, rect.Bottom - bottomCurveSize, bottomCurveSize, bottomCurveSize, 90, 90);
            }
            else
            {
                path.AddLine(rect.X, rect.Bottom, rect.X, rect.Bottom);
            }

            path.CloseFigure();
            return path;
        }

       protected override void OnPaint(PaintEventArgs e)
       {
           RectangleF rectViewport = new RectangleF(0, 0, Width, Height);
           RectangleF rectBorder = new RectangleF(1, 1, Width - 2, Height - 2.5f);

            if (_borderRadius > 2 || _Bottom_borderRadius > 2)
            {
                using (GraphicsPath pathViewport = GetRoundedPath(rectViewport, _borderRadius, _Bottom_borderRadius))
                using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, _borderRadius - 1, _Bottom_borderRadius - 1))
               using (Pen penBorder = new Pen(_borderColor, _borderSize))
               {
                   e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                   // Set region for the panel to cut off external parts
                   Region = new Region(pathViewport);

                   // Draw background manually to prevent default square background drawing artifacts on edges
                   using (Brush brushBackground = new SolidBrush(BackColor))
                   {
                       e.Graphics.FillPath(brushBackground, pathViewport);
                   }

                   // Draw border if needed
                   if (_borderSize > 0 && _borderColor != Color.Transparent)
                   {
                       penBorder.Alignment = PenAlignment.Inset;
                       e.Graphics.DrawPath(penBorder, pathBorder);
                   }
               }
           }
           else
           {
               Region = new Region(rectViewport);
               if (_borderSize > 0 && _borderColor != Color.Transparent)
               {
                   using (Pen penBorder = new Pen(_borderColor, _borderSize))
                   {
                       penBorder.Alignment = PenAlignment.Inset;
                       e.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                   }
               }
           }

           base.OnPaint(e);
       }
   }
}
