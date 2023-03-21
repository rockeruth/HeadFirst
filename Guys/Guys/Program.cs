namespace Guys;
class Program
{
    static void Main(string[] args)
    {
        Guy Joe = new Guy() { Cash = 50, Name = "Joe" };
        Guy Bob = new Guy() { Cash = 100, Name = "Bob" };

        while (true) {
            Joe.WriteMyInfo();
            Bob.WriteMyInfo();
            Console.WriteLine("Enter an amount:");
            string howMuch = Console.ReadLine();
            if (howMuch == "") return;
            if (int.TryParse(howMuch, out int amount)) {
                Console.Write("Who should give the cash: ");
                string whichGuy = Console.ReadLine();
                if (whichGuy == "Joe") {
                    int cashGiven = Joe.GiveCash(amount);
                    Bob.ReceiveCash(cashGiven);
                }
                else if(whichGuy == "Bob") {
                    int cashGiven = Bob.GiveCash(amount);
                    Joe.ReceiveCash(cashGiven);
                }
                else {
                    Console.WriteLine("Please enter 'Joe' or 'Bob'.");
                }
            }
            else {
                Console.WriteLine("Please enter an amount (or a blank line to exit).");
            }
        }

    }
}

