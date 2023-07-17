namespace lab3
{


    class Program
    {
        static void Main()
        {
            int[] numbers = GetNumbersFromUser();

            int product = MultiplyNumbers(numbers);

            Console.WriteLine("The product of these 3 numbers is: " + product);
        }

        static int[] GetNumbersFromUser()
        {
            Console.WriteLine("Please enter 3 numbers:");
            string input = Console.ReadLine();
            string[] numberStrings = input.Split(' ');

            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                if (i < numberStrings.Length && int.TryParse(numberStrings[i], out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    numbers[i] = 1;
                }
            }

            return numbers;
        }

        static int MultiplyNumbers(int[] numbers)
        {
            int product = 1;

            foreach (int number in numbers)
            {
                product *= number;
            }

            return product;
        }

        class Program2
        {
            static void Main()
            {
                int number = GetNumberFromUser(2, 10);
                int[] numbers = GetNumbersFromUser(number);

                double average = CalculateAverage(numbers);

                Console.WriteLine("The average of these " + number + " numbers is: " + average);
            }

            static int GetNumberFromUser(int min, int max)
            {
                int number;
                do
                {
                    Console.WriteLine("Please enter a number between " + min + "-" + max + ":");
                } while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max);

                return number;
            }

            static int[] GetNumbersFromUser(int count)
            {
                int[] numbers = new int[count];

                for (int i = 0; i < count; i++)
                {
                    int input;
                    bool validInput;

                    do
                    {
                        Console.WriteLine((i + 1) + " of " + count + " - Enter a number:");
                        validInput = int.TryParse(Console.ReadLine(), out input) && input >= 0;
                    } while (!validInput);

                    numbers[i] = input;
                }

                return numbers;
            }

            static double CalculateAverage(int[] numbers)
            {
                double sum = 0;

                foreach (int number in numbers)
                {
                    sum += number;
                }

                return sum / numbers.Length;
            }
            class Program3
            {
                public static void PrintPattern()
                {
                    Console.WriteLine("*");
                    Console.WriteLine(" ");
                    Console.WriteLine("***");
                    Console.WriteLine(" ");
                    Console.WriteLine("*****");
                    Console.WriteLine(" ");
                    Console.WriteLine("*******");
                    Console.WriteLine(" ");
                    Console.WriteLine("*********");
                    Console.WriteLine(" ");
                    Console.WriteLine("*******");
                    Console.WriteLine(" ");
                    Console.WriteLine("*****");
                    Console.WriteLine(" ");
                    Console.WriteLine("***");
                    Console.WriteLine(" ");
                    Console.WriteLine("*");
                }
                class Program4 
                {
public static int FindMostFrequentNumber(int[] numbers)
                    {
                        if (Array.Length == 0) 
                        {
                            throw new ArgumentException("Input array cannot be empty.");

                        }
                    }
                }

            }

        }
    }
}
