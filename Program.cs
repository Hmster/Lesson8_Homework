using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = Properties.Settings.Default.applicationName;

            Console.WriteLine($"Previous user name: {Properties.Settings.Default.name}, age: {Properties.Settings.Default.age}, job: {Properties.Settings.Default.job}");

            Console.WriteLine(Properties.Settings.Default.greetings);

            Console.WriteLine("Enter your name:");
            Properties.Settings.Default.name = Console.ReadLine() ;

            Console.WriteLine("Enter your age:");
            Properties.Settings.Default.age = Console.ReadLine() ;

            Console.WriteLine("Enter your job:");
            Properties.Settings.Default.job = Console.ReadLine() ;

            Properties.Settings.Default.Save();

            Properties.Settings.Default.greetings = $"Hello, {Properties.Settings.Default.name}!";
            Console.WriteLine(Properties.Settings.Default.greetings);

            Console.ReadKey(true);
        }
    }
}
