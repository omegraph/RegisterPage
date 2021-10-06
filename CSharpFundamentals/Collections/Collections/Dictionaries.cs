using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Dictionaries
    {
        public void Dictionarie()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string> ();
            myDictionary.Add(1, "Hi");
            myDictionary.Add(2, "Hello");
            myDictionary.Add(3, "Greetings");

            Console.WriteLine(myDictionary[3]);
            Console.ReadKey();

            foreach(KeyValuePair<int, string> kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");

            }
        }
    }
}
