using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    public class DepositAccount : Accounts,IDeposit,IWithDraw
    {
        public const string NoInterest = "No interest for this balance!";
        public const double MinInterestBalance = 0;
        public const double MaxInterestBalance = 1000;
        public DepositAccount(Customers customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(double sum)
        {
            this.Balance += sum;
        }
        public void WithDrawMoney(double sum)
        {
            if (sum>this.Balance)
            {
                throw new ArgumentException("Not enough money!");
            }
            this.Balance -= sum;
        }
        public override double CalculateInterestAmount(int number_of_months)
        {

            if (this.Balance>=MinInterestBalance && this.Balance<=MaxInterestBalance)
            {
                throw new ArgumentException(NoInterest);
            }
            return number_of_months * this.InterestRate;
        }
    }
}
