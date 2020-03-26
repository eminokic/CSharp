using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize an array and random object
            var randomArray = new int[9];
            Random rand = new Random();

            //Insert pseudo random numbers into each index of the array
            for(int i = 0; i < randomArray.Length; i++) {
                randomArray[i] = rand.Next(0,99);
            }

            string originalArray = string.Join(",", randomArray);
            Console.WriteLine("Original Array: " + originalArray);

            //Sort in Ascending Order Using C#'s Sort Method  
            Array.Sort(randomArray);
            string sortedArr = string.Join(",", randomArray);
            Console.WriteLine("Sorted Array: " + sortedArr);

            //Reverse array to recieve it in descending order after sort
            Array.Reverse(randomArray);
            string reverseArr = string.Join(",", randomArray);
            Console.WriteLine("Descending Array: " + reverseArr);
        }
    }
}
