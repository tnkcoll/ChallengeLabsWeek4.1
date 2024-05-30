namespace ChallengeLabsWeek4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = GetInfo("What is your name?");
            customer.Id = GetInfo("What is your Id number?");
            customer.UnitsConsumed = Convert.ToDouble(GetInfo("How many units did you use?"));

            CalculateBill(customer);
        }

        public static string GetInfo(string Info)
        {
            string? userInput;
            do 
            {
                Console.WriteLine(Info);
                userInput = Console.ReadLine();
                return userInput;
            } while (userInput == "");
        }

        public static void CalculateBill(Customer customer)
        {
            double amount = customer.CalculateAmountCharged(customer.UnitsConsumed);
            double surcharge = customer.CalculateSurcharge(amount);
            double NetAmount = customer.CalculateNetAmount(amount, surcharge);

            Console.WriteLine($"Customer ID: {customer.Id}");
            Console.WriteLine($"Customer Name: {customer.Name}");
            Console.WriteLine($"Unit Consumed: {customer.UnitsConsumed}");
            Console.WriteLine($"Amount Charges: ${amount}");
            Console.WriteLine($"Surcharge Amount: ${surcharge}");
            Console.WriteLine($"Net Amount Paid by the Customer: ${NetAmount}");

        }
    }
}
