using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;
        private static readonly object instanceLock = new object();
        private AccountDAO() { }
        public static AccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }

            }
        }

        public Account GetByNameAndPassword(string username, string password)
        {
            Account account = null;
            try
            {
                using (var MySale = new styleContext())
                {
                    account = MySale.Accounts.SingleOrDefault(x => x.Username.Equals(username) && x.Password.Equals(password) && x.Status == 1);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return account;
        }

        public Account GetByName(string username)
        {
            Account account = null;
            try
            {
                using (var MySale = new styleContext())
                {
                    account = MySale.Accounts.SingleOrDefault(x => x.Username.Equals(username));
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return account;
        }

        public Account GetAccountById(int id)
        {
            Account account = null;
            try
            {
                using (var MySale = new styleContext())
                {
                    account = MySale.Accounts.SingleOrDefault(x => x.Id == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return account;
        }

        public List<Account> ListAccountAdmin()
        {
            List<Account> accounts;
            try
            {
                using (var MySale = new styleContext())
                {
                    accounts = MySale.Accounts.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return accounts;
        }

        public void AddAccount(Account account)
        {
            try
            {
                Account c = GetAccountById(account.Id);
                if (c == null)
                {
                    using (var MySale = new styleContext())
                    {
                        MySale.Accounts.Add(account);
                        MySale.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The account is already exist");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateAccount(Account account)
        {
            try
            {
                Account p = GetAccountById(account.Id);
                if (p != null)
                {
                    using (var MySale = new styleContext())
                    {
                        MySale.Entry<Account>(account).State = EntityState.Modified;
                        MySale.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The account does not exist");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
