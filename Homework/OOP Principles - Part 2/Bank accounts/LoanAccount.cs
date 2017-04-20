using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    public class LoanAccount : Accounts,IDeposit
    {
        private const int NoInterestMonthsIndividual = 3;
        private const int NoInterestMonthsCompanies = 2;
        private const string NoInterest = "No interest for these months!";
        public LoanAccount(Customers customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(double sum)
        {
            this.Balance += sum;
        }

        public override double CalculateInterestAmount(int number_of_months)
        {
            if (this.Customer.GetType().Name=="CompaniesCustomer")
            {
                if (number_of_months<=NoInterestMonthsCompanies)
                {
                    throw new ArgumentException(NoInterest);
                }
            }
            if (this.Customer.GetType().Name=="IndividualCustomer")
            {
                if (number_of_months<=NoInterestMonthsIndividual)
                {
                    throw new ArgumentException(NoInterest);
                }
            }
            return number_of_months * this.InterestRate;
        }
    }
}
