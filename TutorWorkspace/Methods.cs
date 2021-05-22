using System;

namespace TutorWorkspace
{
    public class Methods
    {
        /*
         * optionalAccessModifiers returnType methodName(inputParameters...)
         * { 
         *      methodCode; 
         *      return (returnType) returnVariable;
         * }
         * 
         * public - Can be accessed from anywhere that has access to the method's container.
         * static - Can be used without an object reference
         * private - Can only be accessed from within the method's container.
         * 
         */

        public static void SayHello() {
            // Static allows us to reference this method without needing an object to do so.
            // Void means that we do not expect anything back from this method
            Console.WriteLine("Hello, World!");
            return;
        }

        public static void SayHelloToMe(string MyName)
        {
            Console.WriteLine("Hello, " + MyName + "!");
            return;
        }

        public static string WhatIsYourName()
        {
            // Because we have "string" instead of "void", we have to make sure our method returns a variable of the string type.

            string returnString = "I don't have a name, but this program is called \"TutorWorkspace\".";
            return returnString;
        }

        public static double MultiplyNumbers(double NumberOne, double NumberTwo)
        {
            // Now that our return type is "double", we return a double!
            return NumberOne * NumberTwo;
        }

        public static double MultiplyNumbers(float NumberOne, double NumberTwo)
        {
            // What if the user puts in a number of the wrong type? Overloads can help solve this by allowing one
            // method to be used in multiple ways. In this case, the math will still work even if the wrong types are used,
            // but in other cases considerations may have to be made.
            return NumberOne * NumberTwo;
        }


        // ================================================================ //
        // ====================== Try-Catch-Finally ====================== //
        public static void TryCatchFinallyExample()
        {
            try
            {
                /* This code will execute as normal once it is reached. If an exception occurs, it will not continue
                 * and instead jump directly to the catch block.
                 */
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
                Console.WriteLine("This code will never be reached because an error will occur in the previous line." +
                    "There is no index 10 for myNumbers, so an \"IndexOutOfBoundsException\" will occur.");
            }
            catch (Exception e)
            {
                // This code will execute when an exception occurs in the 'try' block.
                Console.WriteLine("Something went wrong in TutorWorkspace.Methods.TryCatchFinallyExample");
                Console.WriteLine(e.StackTrace); // This will tell the console to print the location in the code that the exception happened.
            }
            finally
            {
                Console.WriteLine("The try-catch-finally code has completed.");
            }
        }

        public static void ThrowExceptionExample(int monthIndex)
        {
            /* When something goes wrong in your code it is important to have some way to know that it happened. Throwing
             * an exception allows you to obtain a 'stack trace' which will tell you exactly where in the code
             * the exception was thrown.
             */
            if (monthIndex > 12 || monthIndex < 0)
            {
                throw new Exception(
                    $"There are only 12 months per year. " +
                    $"monthIndex must have an integer value between 1 and 12." +
                    $"Variable monthIndex had value {monthIndex}.\n");
            }
            else
            {
                Console.WriteLine($"The requested month was {monthIndex}\n");
            }
        }

        public static void ThrowExceptionExampleHelper()
        {
            try
            {
                ThrowExceptionExample(13);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine();
            }
            finally
            {
                ThrowExceptionExample(12);
            }
        }
    } // End of Class
} // End of namespace
