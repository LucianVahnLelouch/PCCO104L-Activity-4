using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        string msg = "";
        while (true)
        {
            Console.Write("Enter something: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine("Terminating Program...");
                break;
            }

            if (int.TryParse(userInput, out int number))
            {
                sum += number;
                Console.WriteLine($"Adding {number} to {sum} = {sum}");
            }
            else
            {
                msg += userInput;
                Console.WriteLine($"Current Message is: {msg}");
            }
        }
    }
}