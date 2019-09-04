using System;
using System.Collections.Generic;
using JungleOverloadingExercise.Classes;

namespace JungleOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first and last name.");
            var getFullName = Console.ReadLine();

            string[] splitFirstLastName = getFullName.Split(" ");

            var employee = new Employee(splitFirstLastName[0], splitFirstLastName[1]);

            Console.WriteLine("What's are some restaurants in your area?");
            var aRestaurant = Console.ReadLine();
            String[] allRestaurants = aRestaurant.Split(", ");
            foreach(string restaurant in allRestaurants)
            {
                Console.WriteLine(restaurant);
                employee.MakeRestaurantList(restaurant);
            };

            employee.RandomNumber(1, allRestaurants.Length);

            Console.WriteLine("What do you want to eat at that restaurant?");
            var whatEmployeeWillEat = Console.ReadLine();

            employee.Eat(whatEmployeeWillEat);

            List<Employee> companions = new List<Employee>();
            Console.WriteLine("Type the first and last names of some people you work with.");
            var myCoWorkers = Console.ReadLine();
            string[] teammates = myCoWorkers.Split(", ");
            foreach (var teammateName in teammates)
            {
                string[] firstLast = teammateName.Split(" ");
                var newEmployee = new Employee(firstLast[0], firstLast[1]);
                companions.Add(newEmployee);
            }

            employee.Eat(companions, whatEmployeeWillEat);

        }
    }
}
