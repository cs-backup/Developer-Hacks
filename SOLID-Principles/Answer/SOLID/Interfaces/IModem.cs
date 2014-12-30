
namespace SOLID.Interfaces
{
    // HACK: Which SOLID principles is being violated in following interface? How to fix this?
    // Answer: Single Responsibility Principle
    public interface IDataChannel
    {
        void Send(char c);
        char Receive();
    }

    public interface IConnection
    {
        void Dial(string phoneNumber);
        void Hangup();
    }
}
