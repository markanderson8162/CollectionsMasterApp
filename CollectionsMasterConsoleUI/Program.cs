using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] arrayFifty = new int[50];
			int arrayFiftyLength = arrayFifty.Length-1;
			Populater(arrayFifty);

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50



            //Print the first number of the array
            Console.WriteLine(arrayFifty[0]);
            //Print the last number of the array            
            Console.WriteLine(arrayFifty[arrayFiftyLength]);
            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(arrayFifty);


   //         for(int i = 0; i <= arrayFiftyLength; i++)
			//{
   //             Console.WriteLine(arrayFifty[i]);
			//}

            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(arrayFifty);
            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(arrayFifty);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(arrayFifty);
            NumberPrinter(arrayFifty);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var numberList = new List<int>();

            Console.WriteLine("=====Capacity=====");
            //Print the capacity of the list to the console
            Console.WriteLine($"Capacity: {numberList.Capacity}");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            

            //Print the new capacity
            Populater(numberList);

            Console.WriteLine($"New Capacity: {numberList.Capacity}");
            Console.WriteLine("---------------------");
            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!

            int numberSearch;
            bool isNumber;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isNumber = int.TryParse(Console.ReadLine(), out numberSearch);
            }
            while (!isNumber);

            NumberChecker(numberList, numberSearch);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numberList);

            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numberList);
            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted evens!!");
            numberList.Sort();
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            Console.WriteLine("The List is now an Array!");
            int[] arrayFromList = numberList.ToArray();

            for (int i = 0; i < arrayFromList.Length - 1; i++) 
            {
                Console.WriteLine($"{arrayFromList[i]}");
            }
            //Clear the list
            numberList.Clear();

            #endregion
        }


        private static void ThreeKiller(int[] numbers)
        {
            for(int i = 0; i<numbers.Length; i++)
			{
                if(numbers[i] % 3 == 0)
				{
                    numbers[i] = 0;
				}
                Console.WriteLine(numbers[i]);
			}
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count -1; i >= 0; i--)
            {

                if (numberList[i]%2 != 0)
				{
                    numberList.RemoveAt(i);
				}

			}
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes we got it.");
            }
            else
            {
                Console.WriteLine($"No we don't have it.");
			}
        }

        private static void Populater(List<int> numberList)
        {

			while (numberList.Count < 51)
			{
                Random rng = new Random();               
                var number = rng.Next(0, 50);
                numberList.Add(number);

			}
                NumberPrinter(numberList);
        }



        private static void Populater(int[] numbers)
        {

            for(int i = 0; i < numbers.Length; i++)
			{
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);
			}
        }        

        private static void ReverseArray(int[] array)
        {
             Array.Reverse(array);
                foreach(var item in array)
			    {
                    Console.WriteLine(item);
			    }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
