namespace BankEncapsulation
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            BankAccount yourAccount = new BankAccount();

            Console.WriteLine($"You have ${yourAccount.GetBalance()} haha lol");
            yourAccount.Deposit(500);
            Console.WriteLine($"You just put in ${yourAccount.GetBalance()}. Glad your getting some money...:)");





        }
    }
}
