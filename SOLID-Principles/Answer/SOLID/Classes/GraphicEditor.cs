using System;
namespace SOLID.Classes
{
    //HACK Question: What is the problem in this class design? And how to refactoring this?
    /* Answer: Open / Closed Principle. Problem
       Problem with this design:
            - Impossible to add a new Shape without modying GraphEditor
	        - Tight coupling between GraphEditor and Shpe
	        - Difficult to test a specific shape without invoing GraphEditor
	        - If-Else / Case should be avoided
     */
    public class GraphicEditor
    {
        public void DrawShape(Shape s)
        {
            s.Draw();
        } 
    }

    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }

    public class Circle : Shape
    {
        public Circle()
        {
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }

}
