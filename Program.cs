using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.ReadKey();
        } // Main



        public static void CookingQtyExample()
        {
            double[] ing = { 55.2, 16, 1, .75 };

            for (int i = 0; i < ing.Length; i++)
            {
                Console.WriteLine(ing[i]);
            }

            ChangeAmount(ing, .5);
            Console.WriteLine("-------------------------");
            for (int i = 0; i < ing.Length; i++)
            {
                Console.WriteLine(ing[i]);
            }

            //Console.WriteLine(average);
        }

        public static void MultiplyBy2(int a)
        {
            a *= 2;
        }

        public static void ChangeAmount(double[] qty, double newQty)
        {
            for(int i = 0; i < qty.Length; i++)
            {
                qty[i] *= newQty;
            }
        }

        public static void MoreArrayExamples()
        {
            int[] Prog120grades = { 100, 92, 56, 87, 77, 76, 224, 93, 89 };
            int[] Prog122grades = { 224, 93, 89 };
            int[] Prog140grades = { 100, 92, 56, 87 };

            int[] allClasses =
            {
                (int)SumNumbers(Prog120grades),
                 (int)SumNumbers(Prog122grades),
                 (int)SumNumbers(Prog140grades)
            };

            for (int i = 0; i < allClasses.Length; i++)
            {
                Console.WriteLine(allClasses[i]);
            }

            double avgOfAll = SumNumbers(allClasses);
            Console.WriteLine("Average of all classes" + avgOfAll);
        }

        public static double SumNumbers(int[] grades)
        {
            int howManyElements = grades.Length;
            int total = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                total += grades[i];
            }

            double average = total / (double)grades.Length;
            return average;
        }
        public static void ArraysExample()
        {
            // HOw to declare an array
            string[] students = new string[5];
            //IndexOutOfRangeException - means you tried to use an index that didn't exist
            students[0] = "Meili";
            students[1] = "Monika";
            students[2] = "Breshna";
            students[3] = "Prince";
            students[4] = "Jawan";


            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

        }


        // Method that sums all digits of a number
        public static int SumNumbers(int num)
        {
            int sum = 0;
            int b10 = 10;

            // Loops while num > 0
            while(num > 0)
            {
                // Gets last digit of num
                sum += num % b10;
                
                // Removes last digit of num
                num /= b10;
                Console.WriteLine($"Sum {sum} - Num {num}");
            }

            Console.WriteLine($"Sum {sum} - Num {num}");

            return sum;
            
        }

        // Final Crazy Example ( Looping through a string )

        public static void LoopingThroughAString()
        {

            string num = "12345";

            int total = 0;

            for (int i = 0; i < num.Length; i++)
            {
                // A string is a interupted as a char array
                // So you can iterate through a string using brackets and an index
                // to go through numbers one at a time
                char number = num[i];

                // Here we are totaling the individual values of each number in the number
                // Each loop we save an individual character in variable number
                // Then below we parse that character to an int.
                // int.Parse only takes strings, not a char. So we call .ToString()
                // to convert it to a string.
                // This allows us to sum up an entire string of numbers quickly
                // But this isn't as efficent as our math version we discussed up top
                total += int.Parse(number.ToString());

            }

            Console.WriteLine(total);

        }

        // Questions
        // What is an algorithm
        // How can you sum the individual values of number
        // When do you use a for loop and a while loop

        // Array Keywords: Array, brackets, index, elements, new
        // What types can you make arrays for
        // How do you change a single element in an array
        // How do you loop through an array
        // A string is an array of what?

        // Advanced Practice: How do you effect ever other element in an array
        // Example Array - 1 2 3 4 5
        // Result 1 0 3 0 5

    } // class

} // namespace
