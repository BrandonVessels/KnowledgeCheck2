// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Knowledge_check_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Cat>(); // Use the child class (Cat) here

            for (int i = 0; i < numberOfRecords; i++)
            {
                var cat = new Cat(); // Create an instance of Cat

                Console.WriteLine("Enter the name for the cat: ");
                cat.Name = Console.ReadLine();

                Console.WriteLine("Enter the age for the cat: ");
                cat.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the breed for the cat: ");
                cat.Breed = Console.ReadLine();

                recordList.Add(cat);
            }

            // Print out the list of records
            Console.WriteLine("\nList of Cats:");
            foreach (var cat in recordList)
            {
                Console.WriteLine($"Name: {cat.Name}, Age: {cat.Age}, Breed: {cat.Breed}");
            }
        }
    }
}
