using System;
using System.Text; /* Remove the extra hyphen from string message using StringBuilder https://www.geeksforgeeks.org/stringbuilder-in-c-sharp/ */

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;
            do
            {
                Console.WriteLine("What is your message?");
                string input = Console.ReadLine();
                string upperInput = input.ToUpper();

                // Sum unicode values from each character in string upperInput: https://csharp.net-tutorials.com/data-types/the-char-type/

                int checksum = 0;
                foreach (char ch in upperInput)
                {
                    checksum = checksum + (int)ch;
                }

                // Concatenate unicode values from each character in string upperInput

                string message = "";
                for (int i = 0; i < upperInput.Length; i++)
                {
                    message = (message + "-" + ((int)upperInput[i] - 64));
                }

                // Remove the extra hyphen from string message using StringBuilder: https://www.geeksforgeeks.org/stringbuilder-in-c-sharp/

                StringBuilder removedMessage = new StringBuilder(message);
                removedMessage.Remove(0, 1);

                // Print message and checksum

                Console.WriteLine("Your message is " + removedMessage + ".");
                Console.WriteLine("Message checksum is " + checksum + ".");

                // Ask "Would you like to code another message?" and loop the program if response is affirmative

                Console.WriteLine("Would you like to code another message?");
                string repeatResponse = Console.ReadLine();
                if (repeatResponse.ToUpper() == "YES" || repeatResponse.ToUpper() == "Y")
                {
                    repeat = true;
                } else
                {
                    repeat = false;
                }

            } while (repeat);
        }
    }
}

// © Tomás Calvo 2020
