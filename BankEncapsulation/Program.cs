namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(0);

            account.Deposit(100);
            Console.WriteLine(account.GetBalance());
            
                        
        }
    }
}
