using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");
        var input = Console.ReadLine();
        var calculator = new Calculator();

        switch (input)
        {
            case "1":
                if (TryGetTwoIntegers(out int addNumOne, out int addNumTwo))
                {
                    Console.Write($"{addNumOne} + {addNumTwo} = ");
                    Console.Write(calculator.Add(addNumOne, addNumTwo));
                }
                break;

            case "2":
                if (TryGetTwoIntegers(out int subNumOne, out int subNumTwo))
                {
                    Console.Write($"{subNumOne} - {subNumTwo} = ");
                    Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                }
                break;

            case "3":
                if (TryGetTwoIntegers(out int mulNumOne, out int mulNumTwo))
                {
                    Console.Write($"{mulNumOne} * {mulNumTwo} = ");
                    Console.Write(calculator.Multiply(mulNumOne, mulNumTwo));
                }
                break;

            case "4":
                Console.WriteLine("Enter two numbers to divide:");
                var divideNumber1 = Console.ReadLine();
                var divideNumber2 = Console.ReadLine();

                if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
                {
                    Console.Write($"{divNumOne} / {divNumTwo} = ");
                    Console.Write(calculator.Divide(divNumOne, divNumTwo));
                }
                else
                {
                    Console.WriteLine("One or more of the numbers is not a number");
                }
                break;

            default:
                Console.WriteLine("Unknown input");
                break;
        }
    }

    static bool TryGetTwoIntegers(out int num1, out int num2)
    {
        Console.WriteLine("Enter two integers:");
        var input1 = Console.ReadLine();
        var input2 = Console.ReadLine();

        if (int.TryParse(input1, out num1) && int.TryParse(input2, out num2))
        {
            return true;
        }

        // Assign default values to ensure the out parameters are always set
        num1 = 0;
        num2 = 0;

        Console.WriteLine("One or more of the numbers is not an int");
        return false;
    }

}

}