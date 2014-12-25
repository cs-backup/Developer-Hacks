using System;
namespace SOLID.Classes
{
    //HACK Question: What is the problem in this class design? And how to refactoring this?

    public class GraphicEditor
    {
        public void DrawShape(Shape s)
        {
            if (s.Type == 1)
            {
                DrawRectangele(s as Rectangle);
            }
            else if (s.Type == 2)
            {
                DrawCrircle(s as Circle);
            }
        }
        public void DrawCrircle(Circle c)
        {
            // Implementation here
        }

        public void DrawRectangele(Rectangle r)
        {
            // Implementation here
        }
    }

    public abstract class Shape
    {
        public int Type { get; set; }
    }

    public class Rectangle : Shape
    {
        public Rectangle()
        {
            base.Type = 1;
        }
    }

    public class Circle : Shape
    {
        public Circle()
        {
            base.Type = 2;
        }
    }

}
