using System;

namespace AddMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AddList<int,String> days = new AddList<int, String>();
            days.Add(1,"Monday");
            days.Add(2,"Tuesday");
            days.Add(3,"Wednesday");
            days.Add(4,"Thursday");
            days.Add(5,"Friday");
            days.Add(6,"Saturday");
            days.Add(7,"Sunday");

            for (int i = 0; i < days.Count-1; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }

    
}
