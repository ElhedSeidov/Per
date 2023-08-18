using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanks
{
    public class UniBankCard : Card
    { 
        
        
        public  UniBankCard(string nameAndSurname,  string code, string cvv, decimal balance, decimal addMoney, decimal substractMoney):base(
            nameAndSurname, code, cvv, balance, addMoney,substractMoney)
        {
          
        }       
        public override void Substract()
        {
             Balance = Balance - (SubstractMoney+SubstractMoney*1.5M/100M);
        }
       
    }
}
