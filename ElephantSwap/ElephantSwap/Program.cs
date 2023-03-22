namespace ElephantSwap;
class Program
{
    static void Main(string[] args)
    {
        Elephant Lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        Elephant Lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

        //Lloyd.HearMessage("Hi", Lucinda);
        //Lucinda.SpeakTo(Lloyd, "Hi, Lloyd!");


        Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap.");
        while (true)
        {
            char input = Console.ReadKey(true).KeyChar;
            Console.WriteLine("You pressed " + input);

            if (input == '1')
            {
                Console.WriteLine("Calling Lloyd.WhoAmI()");
                Lloyd.WhoAmI();
            }
            else if (input == '2')
            {
                Console.WriteLine("Calling Lucinda.WhoAmI()");
                Lucinda.WhoAmI();
            }
            else if (input == '3')
            {
                Elephant holder;
                holder = Lloyd;
                Lloyd = Lucinda;
                Lucinda = holder;
                Console.WriteLine("References has been swapped.");
            }
            else if (input == '4')
            {
                Lloyd = Lucinda;
                Lloyd.EarSize = 4321;
                Lloyd.WhoAmI();
            }
            else if (input == '5')
            {
                Lucinda.SpeakTo(Lloyd, "Hi, Lloyd!");
            }
            else return;
            Console.WriteLine();
        }
    }
}

