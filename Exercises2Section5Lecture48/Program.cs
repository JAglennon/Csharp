using System;

namespace Exercises2Section5Lecture48
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1:
            Console.WriteLine(ExerciseOne());

            //Exercise 2:
            Console.WriteLine(ExerciseTwo());

            //Exercise 3:
            Console.WriteLine(ExerciseThree());

            //Exercise 4:
            Console.WriteLine(Exercise4());

            //Exercise 5:
            Console.WriteLine(Exercise5());
        }

        public static int ExerciseOne()
        {
            var count = 0;
            for (var i = 1; i < 100; i++)
            {
                if(i % 3 == 0)
                {
                    count++;
                }
            }
            return count;

        }

        public static int ExerciseTwo()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            return sum;

        }

        public static string ExerciseThree()
        {
            Console.Write("Enter a number: ");

            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;

            for (var i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return (" " + number +"!" + "=" + factorial);
        }

        public static string  Exercise4()
        {
            var number = new Random().Next(1, 10);

            Console.WriteLine("Secret is " + number);
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    return "You Won";

                }
            }

            return "You lost!";
        }

        public static string Exercise5()
        {
            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            return ("Max is " + max);

        }




        }

    }

