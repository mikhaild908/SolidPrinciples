/*******************************************************************************
 Software entities(classes, modules, functions, etc) should be open for
 extension but closed for modification.
*******************************************************************************/

using System;
using System.Collections;

namespace SolidLib.OpenClosed
{
    public interface Shape
    {
        void Draw();
    }

    public class Square : Shape
    {
        public void Draw()
        {
            throw new NotImplementedException();
        }
    }

    public class Circle : Shape
    {
        public void Draw()
        {
            throw new NotImplementedException();
        }
    }

    public class ShapeClient
    {
        // Note: if you add a new shape, you do not need to change DrawAllShapes()
        public void DrawAllShapes(IList shapes)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}