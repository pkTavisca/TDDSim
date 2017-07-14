using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice:\n1.String\n2.Integer\n3.Decimal\n4.Boolean");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Enter value: ");
            string s = Console.ReadLine();
            int i;
            decimal d;
            bool b;
            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    i = int.Parse(s);
                    break;
                case 3:
                    d = decimal.Parse(s);
                    break;
                case 4:
                    b = bool.Parse(s);
                    break;
            }



        }
    }
}
