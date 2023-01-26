namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your favorite school subject: ");
            var favSubject = Console.ReadLine();
            switch (favSubject.ToLower())
            {
                case "potions":
                    Console.WriteLine("Snape approves.");
                    break;
                case "flying":
                    Console.WriteLine("Don't fall off your broomstick.");
                    break;
                case "herbology":
                    Console.WriteLine("Those shrieking plants sure are loud.");
                    break;
                case "defence against the dark arts":
                    Console.WriteLine("Lots of professors to pick from.");
                    break;
                case "transfiguration":
                    Console.WriteLine("Have fun turning into a cat.");
                    break;
                default:
                    Console.WriteLine("Wait, is this not Hogwarts?");
                    break;
            }
        }
    }
}