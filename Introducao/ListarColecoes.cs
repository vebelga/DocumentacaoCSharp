﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao
{
    public static class ListarColecoes
    {
        public static void WorkWithStrings()
        {
            List<string> names = ["Venancio", "Ana", "Felipe"];

            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");
            Console.WriteLine($"The list has {names.Count} people in it");

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");

            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }

        public static void WorkWithInt() {
            List<int> fibonacciNumbers = [1, 1];

            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }

        public static void Desafio()
        {
            List<int> fibonacciNumbers = [1, 1];

            int i = 1;
            while(fibonacciNumbers.Count() < 20)
            {
                var previous = fibonacciNumbers[i - 1];
                var previous2 = fibonacciNumbers[i];

                fibonacciNumbers.Add(previous + previous2);
                i++;
            }

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
