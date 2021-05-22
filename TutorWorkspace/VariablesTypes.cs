#pragma warning disable 414
#pragma warning disable IDE0040
#pragma warning disable IDE0044
#pragma warning disable IDE0051
#pragma warning disable IDE0052


using System;
using System.Collections.Generic;
using System.Text;

namespace TutorWorkspace
{
    class VariablesTypes
    {
        /*  Generally, variables are declared as:
         *
         *      type variableName = value;
        */


        bool MyBool = true; // A boolean is a true or false statement. Represented as 0 for 'false' and 1 for 'true'.



        string MyString = "A series of characters! A string always uses double quotes in C#.";
        String MyOtherString = "Use backslash, right above enter, to use quotes in a string: ' \" ' <- like this";



        char MyCharacter = 'a'; // A Character variable always uses single quotes in C#.
        char MyOtherCharacter = '1'; // Numbers have character representations too!
        //char IncorrectCharacter = 'aa'; // A character varaible only has enough space for one character at a time!




        int aNumber = 0; // -2,147,483,648 to 2,147,483,647, 32 bit
        Int32 anotherNumber = 1; // Functionally identical to "int"
        uint yetAnotherNumber = 2; // Same range size as int, but only positive, hence "unsigned" 
        long biggerNumber = 3; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 ; 64 bit, unsigned version as well.



        float FltType = 3.14159f; // range ±1.5 x 10^−45 to ±3.4 x 10^38, precision ~6-9 digits, DOES need the "f" at the end. 4 bytes
        double DubType = 3.14159d; // ±5.0 × 10^−324 to ±1.7 × 10^308, precision 15-17 digits, 8 bytes, DOES NOT need the "d" at the end
        decimal DecType = 3.14159m; // ±1.0 x 10^-28 to ±7.9228 x 10^28, precision 28-29 digits, 16 bytes, DOES need the "m" at the end



        // You can do math with numeric variables!
        double MathyNumber = 5 + (2 * 100) - (16 / 4);














        // ================================================================ //
        // ======================     Arrays     ========================== //
        // Arrays are a bunch of variables stored into one place.

        // First, you declare the type of variable you want to store, and then place brackets after it
        // int[]

        // Then give the variable a name as usual.

        // Then assign the array its value, if applicable. If the array is to be manually defined, use curly
        // brackets to enclose the values, and separate each value by commas.



        int[] MyIntArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static char[] MyCharArray = new char[] { 'a', 'b', 'c', '1', '2', '3' };
        static string[] MyStringArray = new string[] { "Index 0", "Index 1", "Index 2", "Index 3" };

        // You can access a specific element of an array by referencing which index position it is in. (Most langs are base-0)
        char MyCharFromArray = MyCharArray[3]; // This value will be '1', because 0 = 'a', 1 = 'b', 2 = 'c', 3 = '1'

        // You can also make arrays of arrays.
        int[,] TwoDimensionalArray = new int[,] 
        { 
            { 1, 2, 3 }, // Array 1
            { 4, 5, 6 }, // Array 2 
            { 7, 8, 9 }  // Array 3
        };



        string[,,] ThreeDimensionalArray = new string[,,]
        { // Array container starts with these curly braces
            { // First contained array, Index 1 = 0
                { "Index 0, 0, 0", "Index 0, 0, 1", "Index 0, 0, 2" }, // First interior array, Index 2 = 0
                { "Index 0, 1, 0", "Index 0, 1, 1", "Index 0, 1, 2" }, // First interior array, Index 2 = 1
                { "Index 0, 2, 0", "Index 0, 2, 1", "Index 0, 2, 2" }  // First interior array, Index 2 = 2
            },
            { // Second contained array, Index 1 = 1
                { "Index 1, 0, 0", "Index 1, 0, 1", "Index 1, 0, 2" }, // First interior array, Index 2 = 0
                { "Index 1, 1, 0", "Index 1, 1, 1", "Index 1, 1, 2" }, // First interior array, Index 2 = 1
                { "Index 1, 2, 0", "Index 1, 2, 1", "Index 1, 2, 2" }  // First interior array, Index 2 = 2
            },
            { // Third contained array, Index 1 = 2
                { "Index 2, 0, 0", "Index 2, 0, 1", "Index 2, 0, 2" }, // First interior array, Index 2 = 0
                { "Index 2, 1, 0", "Index 2, 1, 1", "Index 2, 1, 2" }, // First interior array, Index 2 = 1
                { "Index 2, 2, 0", "Index 2, 2, 1", "Index 2, 2, 2" }  // First interior array, Index 2 = 2
            }
        };



        List<Device> DeviceList = new List<Device>();



        // ================================================================ //
        // ======================     Enums      ========================== //
        // Represents a group of constants -> read-only and unchangeable.

        enum Level
        {
            Low,
            Medium,
            High
        }

        public static void EnumExample1()
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }
        public static void EnumExample2()
        {
            Level myVar = Level.High;
            Console.WriteLine((int)myVar);
        }











        // ================================================================ //
        // ======================     Dictionary  ========================= //
        // A way to reference data entries by keys. Similar to an array or list, but 
        // allows more flexibility in the way the data can be found.
        // TODO

    } // End of Class
} // End of namespace





















#pragma warning restore 414
#pragma warning restore IDE0040
#pragma warning restore IDE0044
#pragma warning restore IDE0051
#pragma warning restore IDE0052