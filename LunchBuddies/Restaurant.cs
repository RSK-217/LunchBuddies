using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    internal class Restaurant
    {
        private List<string> _restaurants = new List<string>() { "Taco Hut", "The Banana Place", "Fishes R Us" };
        public string Name { get; set; }

        public Restaurant()
        {
            
            Random random = new Random();
            Name = _restaurants[random.Next(0, _restaurants.Count)];
        
          
        }


    }
}
