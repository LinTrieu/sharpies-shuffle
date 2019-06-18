using System;
using System.Linq;

namespace myApp
{
    class Program
    {
        static void Main()
        {
           string[] TheSharpies = new string[] { "Megan", "Lauren", "Taj", "Ed", "Lin" };      
           Random rand = new Random();
           string[] ShuffledSharpies = TheSharpies.OrderBy(x => rand.Next(TheSharpies.Length)).ToArray();
           Console.WriteLine(ShuffledSharpies);
           for (int i=0; i<5; i++)
            {
            Console.WriteLine(ShuffledSharpies[i]);      
            }         
        }
    }
}
