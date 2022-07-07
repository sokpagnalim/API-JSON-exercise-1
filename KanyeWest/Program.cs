using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            do
            {
                Console.WriteLine($"Kanye says:\"{Kanye.GetQuote()}\"\n");
                Console.WriteLine($"Ron says:{Ron.GetQuote()}\n");
                Console.WriteLine("Continue? Y or N?");
                var response=Console.ReadLine().ToLower();
                cont = (response=="n")? false:true;
                Console.WriteLine();
            }while(cont);
        }



    }
}
