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
            var text = "Jackdaws love my big sphinx of quartz";
            var array2 = text.Split(' ');

            // .ToArray(); 　　模範解答からカット 
            // if (array.Length > 0)　なくてもうまくいったけど、なぜ必要？ 
            var text2 = array2[0];
            var sb2 = new StringBuilder(text2); //インスタンス化してarray2[0]を入れる？ 
            foreach (var word in array2)
            {
                sb2.Append(' ');
                sb2.Append(word);
            }
            var clone2 = sb2.ToString();
            Console.WriteLine(clone2);

            var sb1 = new StringBuilder(text2);
            foreach (var word in array2.Skip(2))
            {
                sb1.Append(' ');
                sb1.Append(word);
            }
            var clone3 = sb1.ToString();
            Console.WriteLine(clone3);

            Console.ReadLine();

        }
    }

    class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
}
