namespace ConsoleTest
{
    static class Alerter
    {
        public static void Red(string prompt)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Routine(prompt);
        }
        public static void Yellow(string prompt) {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Routine(prompt);
        }
        public static void Blue(string prompt)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Routine(prompt);
        }
        public static void Green(string prompt)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Routine(prompt);
        }
        static void Routine(string prompt)
        {
            Console.WriteLine(prompt);
            Console.ResetColor();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Alerter.Blue("--- PART 1 ---");

            Person Bob = new("Bob", 'M', 19);
            Bob.Print();

            Person Customer = new();
            Customer.Print();
            Customer.Input();
            Customer.Print();
            
            Console.ReadKey();
        }
    }
}