﻿using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation: ");

                // Task 1. Read choice input and assing it to new int variable
                int choice = Convert.ToInt32(Console.ReadLine());
                // Task 2. Check if user selected choice 5. If so then exit the loop
                if (choice == 5)
                {
                    break;
                }

                Console.Write("Enter first number: ");
                // Task 3. Get the first number and assing it to new double variable
                double num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                // Task 4. Get the second number and assing it to new double variable
                double num2 = Convert.ToInt32(Console.ReadLine());

                // Task 5. Create double variable for default result value and assign it to be 0
                double defval = 0;
                // Task 6. Handle choices using switch statement
                switch(choice)
                {
                    case 1:
                        Console.WriteLine(add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine(subtract(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine(multiply(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine(divide(num1, num2));
                        break;
                }
                // Task 6.1 For each case create new function/method an call it inside the case
                //          - Case 1: Add 
                //          - Case 2: Subtract
                //          - Case 3: Multiply
                //          - Case 4: Divide, Note remeber to handle 0
                // Note: Think what the default choice should be
                // Note: Declare each case function/method outside Main method
                //       There is comment below where you can place your methods

                // Task 7. Print out the result

                // Code prints result in the switch
            }
        }

        // Declare your methods/functions here
        static double add(double a, double b)
        {
            return a + b;
        }
        static double subtract(double a, double b)
        {
            return a - b;
        }
        static double multiply(double a, double b)
        {
            return a * b;
        }
        static double divide(double a, double b)
        {
            if (b!=0)
                return a / b;
            return 0; // placeholder value if trying to divide by 0 
        }
    }
}