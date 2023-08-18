namespace ConsoleAppBanks
{
    public class Program
    {
        static void Main(string[] args)
         
        {
            var uniBankCard = new UniBankCard("MirzEli","3214568885678903","666",100M,10M,15M);

            uniBankCard.Add();     
            Console.WriteLine(uniBankCard.Balance);
            uniBankCard.Substract();
            Console.WriteLine(uniBankCard.Balance);

           
            var leoBankCard = new LeoBankCard("AhmedKhan", "1234567833334444", "412", 100M, 10M, 20M);

            leoBankCard.Add();
            Console.WriteLine(leoBankCard.Balance);
            leoBankCard.Substract();
            Console.WriteLine(leoBankCard.Balance);

            var accessBankCard = new AccessBankCard("ABdulManaf", "5555342313442222", "655", 100M, 10M, 10M);

            accessBankCard.Add();
            Console.WriteLine(accessBankCard.Balance);
            accessBankCard.Substract();
            Console.WriteLine(accessBankCard.Balance);

            var pashaBankCard = new PashaBankCard("AliBek", "3423134422225555", "333", 100M, 10M, 10M);
            
            pashaBankCard.Add();
            Console.WriteLine(pashaBankCard.Balance);
            pashaBankCard.Substract();
            Console.WriteLine(pashaBankCard.Balance);

        }
    }
}