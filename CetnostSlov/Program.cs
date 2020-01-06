using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CetnostSlov
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Dictionary<string, int> d = new Dictionary<string, int>();
            
            
            Console.Write("Zadej adresu souboru: ");
            string text = Console.ReadLine();
            text = File.ReadAllText(text);

            string[] pole = text.Split(' ');
            int pocet_slov = 0;

            foreach(var item in pole)
            { 
                if (!d.ContainsKey(item))
                {
                    d.Add(item, 1);
                }
                else
                {
                    d[item] += 1;
                }
            }

            Console.WriteLine("slovo      abs. četnost      rel. četnost");
            Console.WriteLine("=========================================");

            foreach (KeyValuePair<string, int> k in d.OrderBy(key => key.Value))
            {

                Console.WriteLine($"{k.Key}     {k.Value}     ");
                

            }
            

            Console.ReadLine();
            


        }
    }
}
