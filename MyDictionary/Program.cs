using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> lessons = new Dictionary<int, string>();
            lessons.Add(1, "C#");
            lessons.Add(2, "Java");
            lessons.Add(3, "Html");
            lessons.Add(4, "C++");
            lessons.Add(5, "Phyton");

            Console.WriteLine("Disctionary size : "+lessons.Count);
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine(lessons.Keys[i] + " --> " + lessons.Values[i]);
            }



            Console.ReadLine();

        }
    }
}
