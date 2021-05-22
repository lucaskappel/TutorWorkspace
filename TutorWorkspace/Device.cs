using System;
using System.Collections.Generic;
using System.Text;

namespace TutorWorkspace
{
    class Device
    {
        // Class objects have parameters which define the details that make each one different from its siblings.
        // In a class, these do not have to be defined upon typing, but can be declared when an object of this type is created.

        public string deviceModel; // This variable is public. It can be accessed by calling the parameter as 'Object.deviceModel'
        private string operatingSystem; // This variable is private. It can only be accessed with other tools this class offers.

        public double screenWidth;
        public double screenHeight;


        // ================================================ //


        // Every object class should have a constructor. This defines what the object will look like to start by passing
        // initialization parameters.

        // The default constructor looks like this:
        public Device() { }



        // A custom constructor looks more like this:
        public Device(string deviceModel, double screenWidth, double screenHeight)
        {
            // Note that the constructor only uses an access modifier and the class name. When called, the constructor
            // will return an object of the type class.

            this.deviceModel = deviceModel;
            operatingSystem = "Linux 11";
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
        }



        // ================================================ //

        public string getOperatingSystem() { 
            /* Because this class' parameter 'operatingSystem' is private, a helper method such as this one is required
             * to access and read its value.
             */
            return this.operatingSystem; 
        }
        public void setOperatingSystem(string operatingSystem) {
            /* Similarly to how this parameter cannot be read without a helper method, it cannot be changed without
             * one as well. The return type is void because we do not need any information back; we are only
             * changing the value of 'operatingSystem' to what we provide as the input parameter.
             */
            this.operatingSystem = operatingSystem;
            return;
        }

        public double getScreenArea()
        {
            /* Screen Area is not a value that is defined by this class naturally. However, it is able to be
             * found using the information in the class. Every device screen will have a width and a height
             * as dictated by the constructor. This means that all we need to do to get the area is a little math.
             */
            return this.screenWidth * this.screenHeight;
        }





        // ================================================ //






        public override string ToString()
        {
            /* Most objects will have a "ToString" method which defines what it looks like in the display. This can help
             * speed up debugging by providing a programmer with a quick way to display all the relevant information
             * about her objects.
             * 
             * Because all classes inherit Object by default, which has its own "ToString" method, we must include
             * the 'override' keyword to let the program know that we want to use our own version of the method
             * instead of the default one provided by Object.
             */
            string returnString = 
                $"Model: { this.deviceModel }\n" +
                $"OS: { this.operatingSystem }\n" +
                $"Screen (cm): { this.screenWidth } x { this.screenHeight }\n";

            return returnString;
        }
    } // End of Class
} // End of namespace
