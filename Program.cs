using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string[] namesArray = { "Tim", "Martin", "Nikki", "Sara" };

            bool[] boolArray = { true, false, true, false, true, false, true, false, true, false };

            List<string> iceCreamFlavors = new List<string>();
            iceCreamFlavors.Add("Vanilla");
            iceCreamFlavors.Add("Chocolate");
            iceCreamFlavors.Add("Strawberry");
            iceCreamFlavors.Add("Butter Pecan");
            iceCreamFlavors.Add("Cookie Dough");
            Console.WriteLine(iceCreamFlavors.Count);
            Console.WriteLine(iceCreamFlavors[2]);
            iceCreamFlavors.RemoveAt(2);
            Console.WriteLine(iceCreamFlavors.Count);

            Dictionary<string, string> userInfo = new Dictionary<string, string>();
            Random rand = new Random();
            userInfo.Add(namesArray[0], iceCreamFlavors[rand.Next(iceCreamFlavors.Count - 1)]);
            userInfo.Add(namesArray[1], iceCreamFlavors[rand.Next(iceCreamFlavors.Count - 1)]);
            userInfo.Add(namesArray[2], iceCreamFlavors[rand.Next(iceCreamFlavors.Count - 1)]);
            userInfo.Add(namesArray[3], iceCreamFlavors[rand.Next(iceCreamFlavors.Count - 1)]);
            foreach (KeyValuePair<string, string> entry in userInfo)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
