using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static Tuple<string?, string?> GetUserNumbers(string message)
        {
            Console.WriteLine($"Enter 2 integers to");
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();
            

            return new Tuple<string?, string?>(number1, number2);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    var result = GetUserNumbers("add");




                    if (int.TryParse(result.Item1, out int addNumOne) && int.TryParse(result.Item2, out int addNumTwo))
                    {
                        Console.Write($"{addNumOne} + {addNumTwo} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                     var result2 = GetUserNumbers("subtract");



                    if (int.TryParse(result2.Item1, out int subNumOne) && int.TryParse(result2.Item2, out int subNumTwo))
                    {
                        Console.Write($"{result2.Item1} - {result2.Item2} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    var result3 = GetUserNumbers("mulitply");


                    if (int.TryParse(result3.Item1, out int multNumOne) && int.TryParse(result3.Item2, out int multNumTwo))
                    {
                        Console.Write($"{result3.Item1} * {result3.Item2} = ");
                        Console.Write(calculator.Multiply(multNumOne, multNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "4":
                    var result4 = GetUserNumbers("divide");
                   
                    if (double.TryParse(result4.Item1, out double divNumOne) && double.TryParse(result4.Item2, out double divNumTwo))
                    {
                        Console.Write($"{result4.Item1} / {result4.Item2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;
                    

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}