namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var account = new BankAccount();
            Console.WriteLine("How much are you depositing today?");
            var amount = double.Parse(Console.ReadLine());


            account.Deposit(amount);

            Console.WriteLine($"your balance is {account.GetBalance()}");
            
        }
    }
}
