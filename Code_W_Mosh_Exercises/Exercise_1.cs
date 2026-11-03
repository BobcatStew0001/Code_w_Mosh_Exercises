 public static int GetAge(string inputString)
 {
    var input = inputString.Split(" ");
    int age;
    var userAge = Convert.ToInt32(input[0]);
    return userAge;
 }
         
   //Exercise 1 
Console.WriteLine("Enter a number between 1 and 10!");
    var userInput1 = Convert.ToInt32(Console.ReadLine());
        switch (userInput1)
        {
         case 1:
         case 2:
         case 3:
         case 4:
         case 5:
         case 6:
         case 7:
         case 8:
         case 9:
         case 10:
             Console.WriteLine("Valid");
             break;
         default:
             Console.WriteLine("Invalid");
             break;
        }
 //Exercise 2
    Console.WriteLine("Enter another number between 1 and 10!");
             var userInput2 = Convert.ToInt32(Console.ReadLine());
             if (userInput1 > userInput2)
             {
                 Console.WriteLine($"{userInput1} is larger");
             }
             else if (userInput1 < userInput2)
             {
                 Console.WriteLine($"{userInput2} is larger");
             }
             else
             {
                 Console.WriteLine($"They are Equal!");
             } 
 //Exercise 3
        Console.WriteLine("Enter the height and width of a room separated by a space");
      var room = Console.ReadLine().Split(" ");
      int height = Convert.ToInt32(room[0]);
      int width = Convert.ToInt32(room[1]);
      if (height > width)
      {
          Console.WriteLine("This is portrait");
      }
      else if (height < width)
      {
          Console.WriteLine("This is landscape");
      }
      else
      {
          Console.WriteLine("This is neither or you did something wrong");
     
      }
     
      Console.Write("What is the speed limit? ");
      var speedLimit = Convert.ToInt32(Console.ReadLine());
     
      Console.Write("What is the speed of this car? ");
      var carSpeed = Convert.ToInt32(Console.ReadLine());
     
      if (carSpeed < speedLimit)
          Console.WriteLine("Ok");
      else
      {
          const int mphPerDemeritPoint = 5;
          var demeritPoints = (carSpeed - speedLimit) / mphPerDemeritPoint;
          if (demeritPoints > 12)
              Console.WriteLine("License Suspended");
          else
              Console.WriteLine("Demerit points: " + demeritPoints);
     }