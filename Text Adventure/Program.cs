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
            Console.WriteLine(name + ", Welcome! We have 4 burgers to choose from.");
            Console.WriteLine("We have a bacon cheeseburger, vegetarian, triple meat cheeseburger, The Works.");
            Console.WriteLine("Which one would you like:");
            string response;
            response = Console.ReadLine();

            if (response == "bacon cheeseburger")
            {
                Console.WriteLine(name + ", you will enjoy the 5 pieces of apple wood smoked bacon we use." );
            }
            else if (response == "vegetarian")
            {
                Console.WriteLine(name + ", we have a meatless patty made from black beans and mushrooms.");
                Console.WriteLine("Our hippie customers really love it!");
            }
            else if (response == "triple meat cheeseburger")
            {
                Console.WriteLine("You will need to see a cardiologist after eating this burger.");
            }
            else if (response == "The Works")
            {
                Console.WriteLine("This has 3 patties, triple cheese, onions, lettuce and our secret sauce.");
                Console.WriteLine("It is our top seller.");
            }

            string input;
            Console.WriteLine(name + ", Did you enjoy your burger?");
            input = Console.ReadLine();
                                
        
            if (input == "yes")
            {
                Console.WriteLine("Glad you enjoyed it.");
            }
            else if (input == "no")
            {
                Console.WriteLine("Get out of here, no more burgers for you!");
            }
        }
    }
}
