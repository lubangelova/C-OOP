using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    public class Bank
    {
        private List<Accounts> accounts = new List<Accounts>();
        public Bank(List<Accounts> accounts)
        {
            this.Accounts = accounts;
        }

        public List<Accounts> Accounts
        {
            get
            {
                return this.accounts;
            }
            private set
            {
                this.accounts = value;
            }
        }
    }
}
