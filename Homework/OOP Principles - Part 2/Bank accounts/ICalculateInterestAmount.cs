using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
   public interface ICalculateInterestAmount
    {
        double CalculateInterestAmount(int number_of_months);
      
    }
}
