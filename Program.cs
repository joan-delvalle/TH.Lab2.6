using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.Lab2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
                List<string> contacts = new List<string>();

                Console.WriteLine("=== Contact Deduplicator ===");
                Console.WriteLine("Enter 15 contact names (duplicates allowed):");

                for (int i = 0; i < 15; i++)
                {
                    Console.Write($"Enter contact #{i + 1}: ");
                    string name = Console.ReadLine().Trim();
                    contacts.Add(name);
                }

                var uniqueSortedContacts = contacts
                    .Select(name => name.Trim().ToLower())      
                    .Distinct()                               
                    .Select(name => Capitalize(name))           
                    .OrderBy(name => name)                      
                    .ToList();

                Console.WriteLine("\n=== Unique, Sorted Contacts ===");
                foreach (var contact in uniqueSortedContacts)
                {
                    Console.WriteLine(contact);
                }
            }

            static string Capitalize(string input)
            {
                if (string.IsNullOrEmpty(input)) return input;
                return char.ToUpper(input[0]) + input.Substring(1).ToLower();
            }
        
    }


}
