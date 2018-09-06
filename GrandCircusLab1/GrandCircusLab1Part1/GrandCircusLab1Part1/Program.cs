using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab1
{
    class Program
    {
        static void Main(string[] args)
        {// declaration and inputs
            string input1;
            string input2;
            Console.WriteLine("Input a number greater than zero.");
            input1 = Console.ReadLine();
            Console.WriteLine("Enter a number greater than zero and with the same number of digits as the first number.");
            input2 = Console.ReadLine();
            Console.WriteLine(input1);
            
            //validating same length of inputs w/ a module.
            var userInputValidationResult = ValidateUserInput(input1, input2);
            if (!userInputValidationResult)
            {
                Console.WriteLine("Validation failed. Please try again.");
            }

            //checking if the inputs add together to be true or false w/ a module.
            var mathResult = DoMath(input1, input2);

            Console.ReadLine();
        }

        //validating input length module.
        public static bool ValidateUserInput(string input1, string input2)
        {
            if (input1.Length != input2.Length)
            {
                Console.WriteLine("Numbers were not the same length.");
                return false;
            }

            //making sure numbers are not 0's or letters.
            if (!int.TryParse(input1, out int number1) && !int.TryParse(input1, out int number2))
            {
                if (number1 == 0 || number2 == 0)
                {
                    Console.WriteLine("Please enter a number greater than zero.");
                    return false;
                }

                Console.WriteLine("There was an error parsing data. Please use numbers only.");
                return false;
            }

            return true;
        }

        //comparing list module for the two inputs.
        public static bool DoMath(string input1, string input2)
        {
            var numArray1 = input1.ToCharArray().Select(Convert.ToInt32).ToList();
            var numArray2 = input2.ToCharArray().Select(Convert.ToInt32).ToList();

            var sum = new List<int>();
            for (int i = 0; i < input1.Length; i++)
            {
                sum.Add(numArray1[i] + numArray2[i]);
            }

            for (int j = 0; j < sum.Count - 1; j++)
            {
                for (int k = j + 1; k < sum.Count; k++)
                {
                    if (sum[j] != sum[k])
                    {
                        Console.WriteLine("Numbers did not add up to the same value. False");
                        return false;
                    }
                }
            }

            Console.WriteLine("Numbers matched. True");
            return true;
        }
    }
}