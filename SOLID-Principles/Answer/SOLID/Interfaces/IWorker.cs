using System;
namespace SOLID.Interfaces
{
    //HACK Question: Can you identify what's the problem in following implementation? If yes, how to fix this?
    // Answer: Liskov Substitution Principle.
    public interface IWork
    {
        void Work();
    }

    public interface IEat
    {
        void Eat();
    }

    public class Human : IWork, IEat
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }

    public class Robot : IWork
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }




}
