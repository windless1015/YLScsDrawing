using System;
using System.Collections.Generic;
using System.Drawing;

namespace YLScsDrawing.Drawing3d
{
    public class Shape3d
    {
       protected Point3d[] pts = new Point3d[8];
        public Point3d[] Point3dArray
        {
            get { return pts; }
        }

        protected Point3d center = new Point3d(0, 0, 0);
        public Point3d Center
        {
            set
            {
                double dx = value.X - center.X;
                double dy = value.Y - center.Y;
                double dz = value.Z - center.Z;
                Point3d.Offset(pts, dx, dy, dz);
                center = value;
            }
            get { return center; }
        }

        protected Color lineColor = Color.Black;
        public Color LineColor
        {
            set { lineColor = value; }
            get { return lineColor; }
        }

        public void RotateAt(Point3d pt, Quaternion q)
        {
            // transform origin to pt
            Point3d[] copy = Point3d.Copy(pts);
            Point3d.Offset(copy,  - pt.X,  - pt.Y,  - pt.Z);

            // rotate
            q.Rotate(copy);
            q.Rotate(center);

            // transform to original origin
            Point3d.Offset(copy, pt.X, pt.Y, pt.Z);
            pts = copy;
        }
        
        public virtual void Draw(Graphics g,Camera cam)
        {
        }
    }
}
