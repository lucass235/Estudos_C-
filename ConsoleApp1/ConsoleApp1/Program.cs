using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            sbyte x = 127;
            byte y = 255; // não aceita numero negativo
            y++;
            bool bol = false;
            int i = 1000;
            Console.WriteLine(bol);
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            Console.WriteLine(minInt);  
            Console.WriteLine(maxInt);  
            
            Console.WriteLine(y);
            Console.WriteLine("Hello, World!");
        }
    }

}