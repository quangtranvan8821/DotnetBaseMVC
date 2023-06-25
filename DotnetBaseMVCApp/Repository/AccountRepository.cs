using DotnetBaseMVCApp.Models;
using DotnetBaseMVCApp.Data;
using DotnetBaseMVCApp.Interfaces;

namespace DotnetBaseMVCApp.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Create(Account account)
        {
            _context.Add(account);
            return Save();
        }

        private bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}