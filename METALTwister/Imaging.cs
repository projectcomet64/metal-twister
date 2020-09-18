using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METALTwister
{
    public static class Imaging
    {
        public static void CreateAnglePreview(float degrees, bool auto, bool freeroam, out Bitmap exit, int w = 100, int h = 100)
        {
            // percentage to take from the width and height
            float pct = 0.85f;
            float degreeCompletion = (degrees % 360) / 360;
            Bitmap bm = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bm))
            {
                g.Clear(Color.Transparent);
                int ballwidth = 10;
                // Bounds of the graphic
                RectangleF limits = new RectangleF(w - w * pct, h - h * pct, w * pct - (w - w * pct), h * pct - (h - h * pct));
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                
                // Bounds of the ellipse for the pointer
                PointF anglePos = new Point((int)(Math.Sin(Math.PI / 180 * degrees) * (w / 2 * pct) + (w / 2)), (int)(Math.Cos(Math.PI / 180 * degrees) * (w / 2 * pct) + (w / 2)));
                Rectangle limitsPointer = new Rectangle((int)anglePos.X - ballwidth / 2, (int)anglePos.Y - ballwidth / 2, ballwidth, ballwidth);

                // Styling
                Pen circleBorder = new Pen(Color.Black, 2f);
                Pen haipuBorder = new Pen(Color.FromArgb((int)(128 * degreeCompletion), Color.Gray), 2f);
                SolidBrush freeroamBrush = new SolidBrush(Color.FromArgb((int)(128 * degreeCompletion), Color.Red));
                LinearGradientBrush pointerBrush = new LinearGradientBrush(new Point(limitsPointer.X, limitsPointer.Y),
                    new Point(limitsPointer.X, limitsPointer.Y + limitsPointer.Height),
                    Color.FromArgb(128,128,128), Color.FromArgb(200, 200, 200));

                // Freeroam circle inner grow
                if (freeroam)
                {
                    g.FillPie(freeroamBrush, new Rectangle(
                        (int)(w / 2 + (float)(limits.Y * (Math.Sqrt(degreeCompletion))) - (w / 2 * (float)Math.Sqrt(degreeCompletion))),
                        (int)(h / 2 + (float)(limits.Y * (Math.Sqrt(degreeCompletion))) - (h / 2 * (float)Math.Sqrt(degreeCompletion))),
                        (int)(Math.Max(1, limits.Width * (float)Math.Sqrt(degreeCompletion))),
                         (int)(Math.Max(1, limits.Height * (float)Math.Sqrt(degreeCompletion)))), 0, 360);
                }
                
                // Auto arc inner grow
                if (auto)
                {
                    g.DrawArc(haipuBorder, new RectangleF(
                        w / 2 + (float)(limits.Y * (Math.Sqrt(degreeCompletion))) - (w / 2 * (float)Math.Sqrt(degreeCompletion)),
                        h / 2 + (float)(limits.Y * (Math.Sqrt(degreeCompletion))) - (h / 2 * (float)Math.Sqrt(degreeCompletion)),
                        Math.Max(1, limits.Width * (float)Math.Sqrt(degreeCompletion)),
                         Math.Max(1, limits.Height * (float)Math.Sqrt(degreeCompletion))), 0, 360);
                    g.DrawArc(haipuBorder, new RectangleF(
                        w / 2 + (limits.Y * degreeCompletion) - (w / 2 * degreeCompletion),
                        h / 2 + (limits.Y * degreeCompletion) - (w / 2 * degreeCompletion),
                       Math.Max(1, limits.Width * degreeCompletion),
                        Math.Max(1, limits.Height * degreeCompletion)), 0, 360);
                }

                // Draw the ring
                g.DrawArc(circleBorder, limits, 0, 360);
                
                // Draw the pointer
                g.FillPie(pointerBrush, limitsPointer, 0, 360);
                g.DrawArc(circleBorder, limitsPointer, 0, 360);
            }
            exit = bm;
        }
    }
}
