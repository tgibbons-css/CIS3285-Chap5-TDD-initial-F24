using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3285_Chap5_TDD_initial_F24
{
    public class Account
    {
        public Account()
        {
            Balance = 200m;
        }

        public void AddTransaction(decimal amount)
        {

        }

        public decimal Balance
        {
            get;
            private set;
        }
    }
}
