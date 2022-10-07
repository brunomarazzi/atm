// ATM Machine. My second study project using C#.

public class Client
{
    public string name { get; set; }
    public string cardNumber { get; set; }
    public int pin { get; set; }
    public double balance { get; set; }

    public Client(string name, string cardNumber, int pin, double balance)
    {
        this.name = name;
        this.cardNumber = cardNumber;
        this.pin = pin;
        this.balance = balance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Select one of the following options: ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(Client currentUser)
        {
            Console.WriteLine("How much money would you like to deposit?");
            double deposit = double.Parse(Console.ReadLine());
            currentUser.balance += deposit;
            Console.WriteLine($"Thank you for your money. Your new balance is {currentUser.balance}");
        }

        void withdraw(Client currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw?");
            double withdraw = double.Parse(Console.ReadLine());
            if (currentUser.balance > withdraw)
            {
                currentUser.balance -= withdraw;
                Console.WriteLine($"Done! Your new balance is {currentUser.balance}");
            }
            else
            {
                Console.WriteLine("Sorry, insufficient balance");
            }
        }

        void balance(Client currentUser)
        {
            Console.WriteLine($"Your current balance is {currentUser.balance}");
        }

        List<Client> cardHolders = new List<Client>();
        cardHolders.Add(new Client("Son Goku", "1234123412341234", 1234, 745.84));
        cardHolders.Add(new Client("Jackson Teller", "4532772818527395", 1234, 745.84));
        cardHolders.Add(new Client("Eren Jaeger", "4532772818527395", 1234, 745.84));
        cardHolders.Add(new Client("Mikasa Ackerman", "4532772818527395", 1234, 745.84));

        //Promt User

        Console.WriteLine("ATM Machine");
        Console.WriteLine("Please enter you card number: ");
        string cardNum = "";
        Client currentUser;

        while (true)
        {
            try
            {
                cardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNumber == cardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card number not recognized. Please try again"); }
            }
            catch
            {
                Console.WriteLine("Card number not recognized. Please try again");
            }
        }

        Console.WriteLine("Please enter your PIN: ");
        int pinNumber = 0;
        while (true)
        {
            try
            {
                pinNumber = int.Parse(Console.ReadLine());
                if (currentUser.pin == pinNumber) { break; }
                else { Console.WriteLine("Incorrect PIN. Please try again."); }
            }
            catch
            {
                Console.WriteLine("Incorrect PIN. Please try again.");
            }
        }

        Console.WriteLine($"Welcome {currentUser.name}");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }

            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }

        } while (option != 4);
        Console.WriteLine("Thank you! Have a nice day");
    }
}