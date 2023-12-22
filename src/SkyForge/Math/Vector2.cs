
namespace SkyForge.Math
{
    public class Vector2
    {
        public float x { get; set; }
        public float y { get; set; }

        public Vector2() : this(0.0f, 0.0f) { }
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Normalized()
        {
            var lenghtVector = (float)System.Math.Sqrt(x * x + y * y);
            x /= lenghtVector;
            y /= lenghtVector;
        }

        public override string ToString()
        {
            return $"x:{x} y:{y}";
        }

        public static Vector2 operator +(Vector2 vector1, Vector2 vector2)
        {
            return new Vector2(vector1.x + vector2.x, vector1.y + vector2.y);
        }

        public static Vector2 operator -(Vector2 vector1, Vector2 vector2)
        {
            return new Vector2(vector1.x + vector2.x, vector1 .y - vector2.y);
        }

        public static Vector2 operator *(Vector2 vector, float value)
        {
            return new Vector2(vector.x * value, vector.y * value);
        }

    }

}