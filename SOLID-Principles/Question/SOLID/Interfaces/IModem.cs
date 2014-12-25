
namespace SOLID.Interfaces
{
    // HACK: Which SOLID principles is being violated in following interface? How to fix this?
    public interface IModem
    {
        void Dial(string phoneNumber);
        void Hangup();
        void Send(char c);
        char Receive();
    }
}
