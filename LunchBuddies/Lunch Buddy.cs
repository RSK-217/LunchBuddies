using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    internal class LunchBuddy
    {

        private string _firstName;

        private string _lastName;

        public LunchBuddy(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public Restaurant Eat()
        {
            Restaurant restaurant = new Restaurant();
            Console.WriteLine($"My buddy {_firstName} {_lastName} is eating at {restaurant.Name}");
            return restaurant;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"My buddy {_firstName} {_lastName} ate {food} at the office.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            Restaurant restaurant = new Restaurant();
            string companionNames = "";
            foreach (LunchBuddy companion in companions)
            {
                companionNames += $"{companion._firstName} {companion._lastName}, ";
            }

                Console.WriteLine($"{_firstName} {_lastName} ate at {restaurant.Name} with {companionNames}");
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            Restaurant restaurant = new Restaurant();

            Console.WriteLine($"{_firstName} {_lastName} ordered {food} at {restaurant.Name} ");
            string companionNames = "";
            foreach (LunchBuddy companion in companions)
            {
                companionNames += $"{companion._firstName} {companion._lastName}, ";
            }
            Console.WriteLine($"{companionNames} are also there.");


    }
    }
}
