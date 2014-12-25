using System;
namespace SOLID.Interfaces
{
    //HACK Question: Can you identify what's the problem in following implementation? If yes, how to fix this?

    public interface IWorker
    {
        void Work();
        void Eat();
    }

    public class Human : IWorker
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

    public class Robot : IWorker
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




}
