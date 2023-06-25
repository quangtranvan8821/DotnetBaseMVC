using DotnetBaseMVCApp.Models;

namespace DotnetBaseMVCApp.Interfaces
{
    public interface IAccountRepository
    {
        bool Create(Account account);
    }
}