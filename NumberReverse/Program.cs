using System;
///-----------------------------------------------------------------
///   Namespace:    NumberReverse
///   Description:  Input an integer & reverse the order of its digits
///   Author:       Derek Wolters                
///   Date:         3.8.17
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------
namespace NumberReverse
{
    class Program
    {
        static void Main()
        {
            //get user input
            Console.WriteLine("Enter a whole number to reverse:");  
            String input = Console.ReadLine();

            //initilize variables
            int num = 0;
            int revNum = 0;
            int temp;

            //check for a whole number & ask for reinput if not
            while (!int.TryParse(input, out temp))
            {
                Console.WriteLine("Not a whole number. Enter a whole number" + 
                    "to reverse:");
                input = Console.ReadLine();
            }

            //convert input string to integer
            num = Convert.ToInt32(input);

            //reverse numbers by shifting places of each digit using remainders
            //and powers of 10
            while (num > 0)
                {
                    revNum = revNum * 10 + num % 10;
                    num = num / 10;
                }
           
            //output result to user
            Console.WriteLine("The reversed number is: " + revNum);
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
