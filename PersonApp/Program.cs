using PersonApp;
using System;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine("Date of birth: " + person.BirthDate);
            Console.WriteLine("Gender: " + person.GetGender);

            Console.ReadLine();
        }
    }
}