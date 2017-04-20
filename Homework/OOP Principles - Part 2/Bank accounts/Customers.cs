using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    public class Customers
    {
        private string name;
        private const string EmptyString = "can not be empty string!";
        public Customers(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"The name {EmptyString}");
                }
                this.name = value;
            }
        }
    }
}
