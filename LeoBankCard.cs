using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanks
{
    public class LeoBankCard : Card
    {
        public  LeoBankCard(string nameAndSurname, string code, string cvv, decimal balance, decimal addMoney, decimal substractMoney)
            :base(nameAndSurname, code, cvv, balance, addMoney, substractMoney)
        {
             
        }
       
             
    }
}

