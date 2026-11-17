namespace ATypes.Math.Core
{
    public struct Vector
    {
        private readonly double _x;
        private readonly double _y;

        public double Length
        {
            get { return Calculus.Sqrt(_x * _x + _y * _y, 2); }
        }

        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double[] ToArray(Vector vector)
        {
            return new double[2] { vector._x, vector._y };
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1._x + v2._x, v1._y + v2._y);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1._x - v2._x, v1._y - v2._y);
        }

        public static Vector operator *(Vector vector, Int32 scalar)
        {
            return new Vector(vector._x * scalar, vector._y * scalar);
        }

        public static Vector operator /(Vector vector, Int32 scalar)
        {
            return new Vector(vector._x / scalar, vector._y / scalar);
        }

        public static implicit operator Vector(double[] c)
        {
            return new Vector(c[0], c[1]);
        }

        public static implicit operator double[](Vector vector)
        {
            return new double[2] { vector._x, vector._y };
        }
    }
}
