/*******************************************************************************
 Subtypes must be substitutable for their base types
*******************************************************************************/

using System;

namespace SolidLib.LiskovSubstitution
{
    // A violation of LSP causing a violation of OCP
    struct Point { double x, y; }

    public enum ShapeType { square, circle };

    public class Shape
    {
        private ShapeType type;

        public Shape(ShapeType t)
        {
            type = t;
        }

        public static void DrawShape(Shape s)
        {
            if (s.type == ShapeType.square)
            {
                (s as Square).Draw();
            }
            else if (s.type == ShapeType.circle)
            {
                (s as Circle).Draw();
            }
        }
    }

    public class Circle : Shape
    {
        private Point center;
        private double radius;

        public Circle() : base(ShapeType.circle) { }
        public void Draw() { }
    }

    public class Square : Shape
    {
        public Square() : base(ShapeType.square) { }
        public void Draw() { }
    }

    // Note: See OpenClosed.cs for a better implementation
    // of Shape, Square, and Circle
}
