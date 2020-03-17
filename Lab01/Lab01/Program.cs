using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartSequence();
        }

        static void StartSequence()
        {
            string answer = "";
            try
            {
                Console.WriteLine("Enter a number greater than zero.");
                answer = Console.ReadLine();
                int number = Convert.ToInt32(answer);
            }
            catch (Exception)
            {
                Console.WriteLine("Thats not a number...");
              
            }
        }
    }
}
