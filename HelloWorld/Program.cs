using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            string[] msgArray = new string[3];

            displayInputs(msgArray);

            reverseMessage(msgArray);

            displayOutputs(msgArray);
        }

        private static void reverseMessage(string[] msgArray)
        {
            char[] charMsgArr = msgArray[2].ToCharArray();
            Array.Reverse(charMsgArr);
            msgArray[2] = String.Concat(charMsgArr);
        }

        private static void displayOutputs(string[] msgArray)
        {
            foreach (string s in msgArray)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }

        private static void displayInputs(string[] msgArray)
        {
            Console.Write("Please key in First Name : ");
            msgArray[0] = Console.ReadLine();

            Console.Write("Please key in Last Name : ");
            msgArray[1] = Console.ReadLine();

            Console.Write("Please key in Messages to be Reversed : ");
            msgArray[2] = Console.ReadLine();

        }
    }
}
