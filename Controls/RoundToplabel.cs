using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace Kiosk.Controls
{
   public class RoundedToplabel: Label
    {
        private int _Top_borderRadius = 90;


        private Color _borderColor = Color.FromArgb(255, 192, 128);
        private float _borderSize = 10;
        


       private bool _showShadow = true;
       private int _shadowDepth = 8;
       private Color _shadowColor = Color.FromArgb(60, 0, 0, 0);
       public int BorderRadius
       {
           get => _Top_borderRadius;
           set { _Top_borderRadius = value; Invalidate(); }

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

        [Browsable(true)]
        [Category("Layout")]
        [DefaultValue(false)]
        public override bool AutoSize
        {
            get => base.AutoSize;
            set => base.AutoSize = value;
        }

        private bool _roundTopLeft = true;
        private bool _roundTopRight = true;

        public bool RoundTopLeft
        {
            get => _roundTopLeft;
            set
            {
                _roundTopLeft = value; Invalidate();
            }
        }

        public bool RoundTopRight
        {
            get => _roundTopRight;
            set
            {
                _roundTopRight = value; Invalidate();
            }
        }

        public bool RoundBottomRight { get; set; } = true;
        public bool RoundBottomLeft { get; set; } = true;

        public RoundedToplabel()
        {
            DoubleBuffered = true;
            this.AutoSize = false;
            base.BorderStyle = BorderStyle.None;
        }

       private GraphicsPath GetRoundedPath(RectangleF rect, float radius)
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

           // Bottom-Right corner (Always flat)
           path.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Bottom);

           // Bottom-Left corner (Always flat)
           path.AddLine(rect.X, rect.Bottom, rect.X, rect.Bottom);

           path.CloseFigure();
           return path;
       }

       protected override void OnPaint(PaintEventArgs e)
       {
           RectangleF rectViewport = new RectangleF(0, 0, Width, Height);
           RectangleF rectBorder = new RectangleF(1, 1, Width - 2, Height - 2);

           if (_Top_borderRadius > 2)
           {
               using (GraphicsPath pathViewport = GetRoundedPath(rectViewport, _Top_borderRadius))
               using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, _Top_borderRadius - 1))
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
