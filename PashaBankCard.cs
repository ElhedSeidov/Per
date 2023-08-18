using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanks
{
    public class PashaBankCard : Card
    {
        public PashaBankCard(string nameAndSurname, string code, string cvv, decimal balance, decimal addMoney, decimal substractMoney)
            : base(nameAndSurname, code, cvv, balance, addMoney, substractMoney)
        {


        }
        

        public override void Add()
        {
            Balance = Balance + (AddMoney - AddMoney * 0.6M / 100M);
        }
        public override void Substract()
        {
            Balance = Balance - (SubstractMoney + SubstractMoney * 1.1M / 100M);
        }

        


        
    }
}
