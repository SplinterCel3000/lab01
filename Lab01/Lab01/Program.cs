﻿using System;

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
            Console.WriteLine("Enter a number greater than zero.");
            answer = Console.ReadLine();
            try
            {
                
                int number = Convert.ToInt32(answer);
                PopulateMethod(number);
             
            }
            catch (Exception)
            {
                Console.WriteLine("Thats not a number...");
              
            }

            
        }
        static void PopulateMethod(int number)
        {
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($" Enter a number {i + 1} of {array.Length} ");
                string input = Console.ReadLine();
                int convert = Convert.ToInt32(input);
                array[i] = convert;
            }
            Console.WriteLine("your numbers are:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
