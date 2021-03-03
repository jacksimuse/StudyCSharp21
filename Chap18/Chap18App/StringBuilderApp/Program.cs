using System;
using System.Text;

namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello World\n");
            //sb[6] = 'N'; // 비추
            sb.Append("My name is Hugo\n");
            sb.Append("I'm 47years old\n");
            sb.Append("Book price is 30,000 won.\n");
            sb.Insert(6, "New");
            sb.Replace("Book", "시계");

            Console.WriteLine(sb);
        }
    }
}
