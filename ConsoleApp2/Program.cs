using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            var text2 = "Cozy lummox gives smart squid who asks for job pen";
            text2 = text2.Replace(" ", "").ToLower();
            
            char[] words = text2.ToCharArray();

            var dictionary = new Dictionary<char, int>();

            foreach(var word in words)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            var new_dic = dictionary.OrderBy(x => x.Key);

            foreach (var v in new_dic)
            {
                Console.WriteLine(v.Key + " : " + v.Value);
            }
            Console.ReadLine();




        }
    }
}
