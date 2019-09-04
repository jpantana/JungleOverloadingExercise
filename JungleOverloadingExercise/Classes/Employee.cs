using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloadingExercise.Classes
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        List<string> myRestaurants = new List<string>();

        public void MakeRestaurantList(string restaurant)
        {
            myRestaurants.Add(restaurant);
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            Console.WriteLine("Time for a lunch break");
            Eat(random.Next(min, max));
            return random.Next(min, max);
        }

        public string Eat(int index)
        {
            Console.WriteLine($"Looks like {FirstName} {LastName} is eating at {myRestaurants[index]}");
            return myRestaurants[index];
        }

        public string Eat(string meal)
        {
            Console.WriteLine($"{FirstName} is eating a {meal}");
            return meal;
        }

        public void Eat(List<Employee> companions, string meal)
        {
            Console.Write($"{FirstName} is out to lunch with "); 

            foreach (var companion in companions)
            {
                string firstNameCompanion = companion.FirstName;
                Console.Write($"{companion.FirstName}, and ");
            }
            Console.Write($" and eating {meal}");
        }

        
    }
}
