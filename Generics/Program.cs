using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("person1");
            names.Add("person2");


            Console.WriteLine(names.Length);


            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }


        }
    }
}
