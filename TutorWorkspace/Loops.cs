using System;
using System.Collections.Generic;
using System.Text;

namespace TutorWorkspace
{
    class Loops
    {
        // ================================ For Loops ================================ //
        /* For loops, when you can know how many times you need to loop before doing anything. I.E. Plant 15 flowers.
         * 
         * for (var IteratorVariable = InitialValue; StopCondition; IteratorVariable change) { code }
         */
        public static void ForLoop1()
        {
            for( int i = 0; i < 8; i++) { Console.WriteLine(i); }
        }
        public static void ForLoop2()
        {
            int Summation = 0;
            for (int i = 0; i < 8; i++) { Summation = Summation + i; }
            Console.WriteLine(Summation);

            Summation = 0;
            for (int i = 0; i < 8; i++) { Summation += i; }
            Console.WriteLine(Summation);
        }

        // ================================ While Loops ================================ //
        /* While loops, when you don't know how long it will take to reach your goal. Typically when you
         * are looking for something. I.E. Plant flowers until there aren't any more to plant.
         * 
         * While loops will continue looping so long as the condition in the parenthesis evaluates to the boolean 'true'.
         * 
         * while(condition) { code }
         */

        public static void WhileLoop1()
        {
            Random RandomNumberGenerator = new Random();
            Double RandomDouble = 0;

            while (RandomDouble <= 0.5)
            {
                RandomDouble = RandomNumberGenerator.NextDouble(); // Generates a decimal number between 0 and 1
                Console.WriteLine("RandomDouble = " + RandomDouble.ToString());
            }
            Console.WriteLine("While loop has been exited because the condition is no longer true.");
        }

        public static void WhileLoop2()
        {
            bool WhileCondition = true;
            Random RandomNumberGenerator = new Random();
            Double RandomDouble = 0;

            while (WhileCondition)
            {
                RandomDouble = RandomNumberGenerator.NextDouble();
                WhileCondition = RandomDouble <= 0.5;
                Console.WriteLine("RandomDouble = " + RandomDouble.ToString());
            }
            Console.WriteLine("While loop has been exited because the condition is no longer true.");
        }
    } // End of Class
} // End of namespace
