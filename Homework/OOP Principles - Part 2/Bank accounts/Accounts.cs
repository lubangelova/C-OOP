using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    public class Accounts:ICalculateInterestAmount
    {
        private Customers customer;
        private double balance;
        private double interestRate;

        public Accounts(Customers customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public Customers Customer
        {
            get
            {
                return this.customer;
            }
            private set
            {
                this.customer = value;
            }
        }
        public double Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }
        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                this.interestRate = value;
            }
        }

        public virtual double CalculateInterestAmount(int number_of_months)
        {
            return this.interestRate * number_of_months;
        }

      
    }
}
