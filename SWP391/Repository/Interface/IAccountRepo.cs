using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IAccountRepo
    {
        Account GetByNameAndPassword(string username, string password);
        Account GetByName(string username);
        Account GetAccountById(int id);
        List<Account> ListAccountAdmin();
        void AddAccount(Account account);
        void UpdateAccount(Account account);
    }
}
