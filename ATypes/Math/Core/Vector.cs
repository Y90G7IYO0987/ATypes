namespace ATypes.Math.Core
{
    public class Vector
    {
        private readonly double _x;
        private readonly double _y;

        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1._x + v2._x, v1._y + v2._y);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1._x - v2._x, v1._y - v2._y);
        }
    }
}
