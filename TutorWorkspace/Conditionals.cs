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
            else if(ExampleBoolean == false) { return; }
            else { Console.WriteLine("ExampleBoolean is false."); }
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
            if (UserChoice.Equals("A"))
            {
                // Perform a
                Console.WriteLine($"User has pressed button {UserChoice}.");
            }
            else if(UserChoice.Equals("B"))
            {
                // Perform b
                Console.WriteLine($"User has pressed button {UserChoice}.");
            }
            else if(UserChoice.Equals("B"))
            {
                // Perform c
                Console.WriteLine($"User has pressed button {UserChoice}.");
            }
            else
            {
                // Perform default
                Console.WriteLine($"User has entered an invalid option.");
            }
            return;
        }
    } // End of Class
} // End of namespace
