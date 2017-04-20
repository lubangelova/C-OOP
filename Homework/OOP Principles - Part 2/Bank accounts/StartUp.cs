using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Accounts deposit = new DepositAccount(new IndividualCustomer("Ivan Ivanov"), 1250, 2);
            Accounts loanCompanyAccount = new LoanAccount(new CompaniesCustomer("Telerik Academy"), 10000, 5);
            Accounts loanIndividualAccount = new LoanAccount(new IndividualCustomer("Pesho Petkov"), 2500, 3);
            Accounts mortageCompanyAccount = new MortgageAccount(new CompaniesCustomer("Opel"), 15000000, 10);
            Accounts mortageIndividualAccount = new MortgageAccount(new IndividualCustomer("Stamat Stamatov"), 500, 3);

            
            Console.WriteLine($"{deposit.GetType().Name} have interest amount: {deposit.CalculateInterestAmount(2)}");
            Console.WriteLine($"{loanCompanyAccount.GetType().Name} have interest amount: {loanCompanyAccount.CalculateInterestAmount(3)}");
            Console.WriteLine($"{loanIndividualAccount.GetType().Name} have interest amount: {loanIndividualAccount.CalculateInterestAmount(8)}");
            Console.WriteLine($"{mortageCompanyAccount.GetType().Name} have interest amount: {mortageCompanyAccount.CalculateInterestAmount(10)}");
            Console.WriteLine($"{mortageIndividualAccount.GetType().Name} have interest amount: {mortageIndividualAccount.CalculateInterestAmount(7)}");
        }
    }
}
