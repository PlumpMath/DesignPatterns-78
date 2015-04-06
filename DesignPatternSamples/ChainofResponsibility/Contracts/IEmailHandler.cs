
namespace ChainofResponsibility.Contracts
{
    public interface IEmailHandler
    {
        IEmailHandler NextHandler { set; }
        void ProcessHandler(string email);
    }
}
