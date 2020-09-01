using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld!");
            //this is a commentary
            //Console.WriteLine("HelloWorld!");
            Console.WriteLine("What`s your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello," + Name);


        }
    }
}
