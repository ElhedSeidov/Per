using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanks
{
    public abstract class Card
    {
        public Card(string nameAndSurname, string code, string cvv, decimal balance, decimal addMoney, decimal substractMoney)
        {
            NameAndSurname = nameAndSurname;

            Code = code;
            CVV = cvv;
            Balance = balance;
            AddMoney = addMoney;
            SubstractMoney = substractMoney;
            
        }

   
    public string NameAndSurname { get; private set; }
        
        public  string Code { get; private set; }
        public  string CVV { get; private set; }
        
        public   decimal AddMoney { get;  private set; }
        public  decimal Balance { get; protected  set; } 
        public  decimal SubstractMoney { get;  private set; }
        public virtual void Add()
        {
            
          Balance = Balance + AddMoney;
            
        }
        public virtual void Substract ()
        {
             Balance = Balance - SubstractMoney;   
            
        }

       
       
    }
}
