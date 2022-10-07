namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newAccount = new BankAccount();

            Console.WriteLine("Hello there! How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            newAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now ${newAccount.GetBalance()}");

        }
    }
}