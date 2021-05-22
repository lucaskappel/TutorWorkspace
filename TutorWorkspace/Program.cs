using System;
using System.Collections.Generic;

namespace TutorWorkspace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int dice1;
            int dice2;
            int dice3;

            Random randomDice = new Random();
            int[] tallySum = new int[19];

            for (int roll = 0; roll <= 36000; ++roll)
            {

                dice1 = randomDice.Next(1, 7);
                dice2 = randomDice.Next(1, 7);
                dice3 = randomDice.Next(1, 7);

                ++tallySum[dice1 + dice2 + dice3];
            }

            // In the first row, display “Sum”, “Frequency” and “Percentage”.
            Console.WriteLine("Sum\tFrequency\tPercentage");

            // Print the remaining rows
            for (int i = 3; i < tallySum.Length; ++i)
            {
                Console.WriteLine($"{i}\t{tallySum[i]}\t{100.0 * tallySum[i] / 36000}");
            }

            Console.ReadKey();
        }



        // ======================================================== //

        
        public static void UserInput()
        {
            Console.WriteLine("Enter Username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName + "!");
        }


        // ======================================================== //



        public static void DeviceExample()
        {
            Console.WriteLine(); // For spacing


            // ================ No constructor, no ToString ================ //

            // Creating device without constructor
            Device MyComputer = new Device();
            MyComputer.deviceModel = "ASUS GO7-T";
            MyComputer.screenWidth = 32;
            MyComputer.screenHeight = 22;

            // Displaying and debugging without ToString
            Console.WriteLine($"Model: {MyComputer.deviceModel}");
            Console.WriteLine($"Screen Area (cm^2): {MyComputer.getScreenArea()}");
            Console.WriteLine($"Operating System: {MyComputer.getOperatingSystem()}");

            // Set the OS to the correct value.
            MyComputer.setOperatingSystem("Windows 10");

            // Display to confirm change
            Console.WriteLine($"Operating System: {MyComputer.getOperatingSystem()}");

            // ================================================================ //


            Console.WriteLine(); // For spacing


            // ================ Constructor and ToString ================ //

            // Creating device with constructor
            Device MyPhone = new Device("Samsung Galaxy S5", 7, 12);

            // Display and debugging with ToString
            Console.WriteLine(MyPhone.ToString());

            // Set the OS to the correct value.
            MyPhone.setOperatingSystem("Android OS v1.1.4.15.8");

            // Display to confirm change
            Console.WriteLine(MyPhone.ToString());

            // ================================================================ //


            Console.WriteLine(); // For spacing
        }
    } // End of Class
} // End of namespace