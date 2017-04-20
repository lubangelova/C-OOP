using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    public class MortgageAccount : Accounts, IDeposit
    {
        public const string NoInterestIndividual = "No interest for these months!";
        public const int InterestMonthsCompanies = 12;
        public const int InterestMonthsIndividuals = 6;
        public MortgageAccount(Customers customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(double sum)
        {
            this.Balance += sum;
        }

        public override double CalculateInterestAmount(int number_of_months)
        {
            if (Customer.GetType().Name == "CompaniesCustomer")
            {
                if (number_of_months <= InterestMonthsCompanies)
                {
                    return (this.InterestRate * number_of_months) / 2;
                }
            }
            if (Customer.GetType().Name == "IndividualCustomer")
            {
                if (number_of_months <= InterestMonthsIndividuals)
                {
                    throw new ArgumentException(NoInterestIndividual);
                }
            }
            return this.InterestRate * number_of_months;
        }
    }
}
