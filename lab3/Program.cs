namespace lab3

{

    using System;
    using System.IO;
    using System.Linq;

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

        public static int FindMostFrequentNumber(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Input array cannot be empty.");
            }

            // Create a dictionary to store the frequency of each number
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            // Iterate through the array and update the frequency count in the dictionary
            foreach (int num in array)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            // Variables to track the most frequent number and its frequency
            int mostFrequentNumber = array[0];
            int maxFrequency = frequencyMap[array[0]];

            // Loop over the dictionary to find the number with the highest frequency
            // kvp means 
            foreach (var kvp in frequencyMap)
            {
                if (kvp.Value > maxFrequency)
                {
                    mostFrequentNumber = kvp.Key;
                    maxFrequency = kvp.Value;
                }
            }

            // Return the most frequent number
            return mostFrequentNumber;
        }
        public static int FindMaximumValue(int[] array)
        {
            int max = array[0]; // Assume the first element as the maximum

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            return max;
        }


        public static void SaveWordToFile()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            try
            {
                // Append the word to the existing "words.txt" file or create a new one if it doesn't exist
                using (StreamWriter writer = File.AppendText("words.txt"))
                {
                    writer.WriteLine(word);
                    Console.WriteLine("Word saved to the file.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        public static void ReadWordsFromFile()
        {
            try
            {
                if (File.Exists("words.txt"))
                {
                    string[] words = File.ReadAllLines("words.txt");
                    if (words.Length > 0)
                    {
                        Console.WriteLine("Words in the file:");
                        foreach (string word in words)
                        {
                            Console.WriteLine(word);
                        }
                    }
                    else
                    {
                        Console.WriteLine("The file is empty.");
                    }
                }
                else
                {
                    Console.WriteLine("The file 'words.txt' does not exist.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading from file: {ex.Message}");
            }
        }
           

            public static void RemoveWordFromFile(string wordToRemove)
            {
                try
                {
                    if (File.Exists("words.txt"))
                    {
                        string[] words = File.ReadAllLines("words.txt");

                        if (words.Contains(wordToRemove))
                        {
                            words = words.Where(word => word != wordToRemove).ToArray();

                            File.WriteAllLines("words.txt", words);
                            Console.WriteLine($"The word '{wordToRemove}' was removed from the file.");
                        }
                        else
                        {
                            Console.WriteLine($"The word '{wordToRemove}' was not found in the file.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The file 'words.txt' does not exist.");
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Error reading or writing to the file: {ex.Message}");
                }
            }

        public static string[] WordAndCharacterCount(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Select(word => $"{word}: {word.Length}").ToArray();
        }

    }

    }






    

