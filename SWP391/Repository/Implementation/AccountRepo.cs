using BusinessObjects.Models;
using DataAccessObject;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class AccountRepo : IAccountRepo
    {
        public void AddAccount(Account account) => AccountDAO.Instance.AddAccount(account);

        public Account GetAccountById(int id) => AccountDAO.Instance.GetAccountById(id);

        public Account GetByName(string username) => AccountDAO.Instance.GetByName(username);

        public Account GetByNameAndPassword(string username, string password) => AccountDAO.Instance.GetByNameAndPassword(username, password);

        public List<Account> ListAccountAdmin() => AccountDAO.Instance.ListAccountAdmin();

        public void UpdateAccount(Account account) => AccountDAO.Instance.UpdateAccount(account);
    }
}
