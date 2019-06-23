using System;

namespace Text_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Welcome to the Burger Barn! What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Welcome {0}, we have 4 burgers to choose from.", name);
            Console.WriteLine("We have a bacon cheeseburger, vegetarian, triple meat cheeseburger, The Works.");
            Console.WriteLine("Which one would you like:");
            string response;
            response = Console.ReadLine();

            if (response == "bacon cheeseburger")
            {
                Console.WriteLine("{0}, You will enjoy the 5 pieces of apple wood smoked bacon we use.", name);
            }
            else if (response == "vegetarian")
            {
                Console.WriteLine("{0}, We have a meatless patty made from black beans and mushrooms.", name);
                Console.WriteLine("Our hippie customers really love it!");
            }
            else if (response == "triple meat cheeseburger")
            {
                Console.WriteLine("You will need to see a cardiologist after eating this.");
            }
            else if (response == "The Works")
            {
                Console.WriteLine("This has 3 patties, triple cheese, onions, lettuce and special sauce");
            }

            Console.WriteLine("{0}, Did you enjoy your burger", name);
            Console.ReadLine();
            if (response == "yes")
            {
                Console.WriteLine("Glad you enjoyed it");
            }
            else if (response == "no")
            {
                Console.WriteLine("Get out of here, no more burgers for you!");
            }
        }
    }
}
