namespace Classes
{
    public class Program
    {
        static void Main(string[]args)
        {
            var classic = new Cars();

            classic.Make = "Epiphony";
            classic.Model = "Highspeed Bolt";
            classic.Year = 2023;

            Console.WriteLine($"This is{classic.Make} {classic.Model} {classic.Year}");


        
        }
    }
}
