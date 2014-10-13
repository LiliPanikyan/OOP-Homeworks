using System;

namespace Test
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D startPoint;

        public double X
        {
            get { return this.x; }
        }
        public double Y
        {
            get { return this.y; }

        }
        public double Z
        {
            get { return this.z; }
        }

        static Point3D()
        {
            Point3D.startPoint = new Point3D(0, 0, 0);
        }
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }
        public static Point3D StartPoint
        {
            get { return startPoint; }
        }

        public override string ToString()
        {
            return String.Format("3D-Point: {0}, {1}, {2} ", this.X, this.Y, this.Z);
        }
    }
}
