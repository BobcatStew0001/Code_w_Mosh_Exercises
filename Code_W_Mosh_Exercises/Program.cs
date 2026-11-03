
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Code_W_Mosh_Exercises
{
    class Program
    {

        
        static void Main(string[] args)
        {
          
           
             
            
            
            
//Iteration Loops Exercise 
//Exercise 1: 
            var count = 0;
            for(var i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} numbers divisible by 3 between 1  and 100.");
//Exercise 2: 
            var totalInput = 0; 
            while (true)
            {
                Console.WriteLine("Enter a number");
                var input = Console.ReadLine();
                if(!int.TryParse(input,out int number))
                {
                    Console.WriteLine("Ok");
                    break;
                }
                totalInput += number;
                
            }
            Console.WriteLine($"Total Input: {totalInput}");
//Exercise 3:
            Console.WriteLine("Enter a number:");
             var userInput = Console.ReadLine();
             var inputCheck = int.TryParse(userInput, out var userNumber);
             var factorial = 1;
             for (var i = userNumber; i > 1; i--)
             {
                  
                 factorial *= i;
                 
                 
             }
            
             Console.WriteLine($"{userNumber}! = {factorial}")

//Exercise 4: 
            var targetNumber = Random.Shared.Next(1, 11);
            Console.WriteLine(targetNumber);
            const int maxTries = 4; 
            for (var i = 0; i < maxTries; i++)
            {
                Console.WriteLine("Enter a number between 1 and 10");
                var guessNumber = Convert.ToInt32(Console.ReadLine());
                
                if (guessNumber == targetNumber)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            
                if (i < maxTries - 1)
                {
                    Console.WriteLine("Try again");
                }
            }
            Console.WriteLine("You Lost!");
//Exercise 5: 
            Console.WriteLine("Enter a group of numbers separated by comma's");
            var input = Console.ReadLine().Split(',');
            var numbers = Array.ConvertAll(input, int.Parse);
            var max = numbers[0]; 
            for (var i = 0; i < numbers.Length; i++)
            {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
            }
            Console.WriteLine(max);
        }


    }
}