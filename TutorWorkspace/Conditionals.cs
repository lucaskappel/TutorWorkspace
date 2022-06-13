using System;
using System.Collections.Generic;
using System.Text;

namespace TutorWorkspace
{
    class Conditionals
    {
        public static void IfBasic()
        {
            bool ExampleBoolean = false;
            if(ExampleBoolean == true) { Console.WriteLine("ExampleBoolean is true." ); }
            if(ExampleBoolean == false) { Console.WriteLine("ExampleBoolean is false."); }
        }

        public static void IfElse()
        {
            bool ExampleBoolean = false;
            if (ExampleBoolean == true) { Console.WriteLine("ExampleBoolean is true."); }
            else if(ExampleBoolean == false) { Console.WriteLine("ExampleBoolean is false."); }
            else { Console.WriteLine("This code will never be reached; booleans can only be true or false."); }
        }

        public static void AvoidConditional()
        {
            bool ExampleBoolean = false;
            Console.WriteLine("ExampleBoolean is " + ExampleBoolean.ToString() );
        }

        public static void IfElseIf()
        {
            Console.WriteLine("Please enter 'A', 'B', or 'C'.");
            var UserChoice = Console.ReadLine();
            
            // We can execute different code based on what the user input.
            if (UserChoice.Equals("A"))
            {
                // Perform a
                Console.WriteLine("User has selected option 1.");
            }
            else if(UserChoice.Equals("B"))
            {
                // Perform b
                Console.WriteLine("User has selected option 2.");
            }
            else if(UserChoice.Equals("C"))
            {
                // Perform c
                Console.WriteLine("User has selected option 3.");
            }
            else
            {
                // In the case that they do not choose one of the above options, we can catch the remaining with the default "else" case.
                // We can output their chocie completely genericly using string formatting: $"This will be text, but {expression} will be evaluated as code."
                Console.WriteLine($"User has entered an invalid option: {UserChoice.toString()}");
            }
            return;
        }
    } // End of Class
} // End of namespace
