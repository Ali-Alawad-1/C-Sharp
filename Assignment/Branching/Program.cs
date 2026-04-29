using System;


namespace PackageExpressV2
{
    class Program
    {
        static void Main()
        {
            // Mandatory Header
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Requesting Mass
            Console.WriteLine("Please enter the package weight:");
            float wgt = float.Parse(Console.ReadLine());

            // Immediate exit if weight threshold is met
            if (wgt > 50.0f)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // Requesting Dimensional Data
                Console.WriteLine("Please enter the package width:");
                float dimW = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                float dimH = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                float dimL = float.Parse(Console.ReadLine());

                // Validate combined size
                if ((dimW + dimH + dimL) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    // Perform calculation: Product of dimensions * weight / 100
                    double volumeMetric = (dimW * dimH * dimL);
                    double totalEstimate = (volumeMetric * wgt) / 100.0;

                    // Display result using string interpolation for a unique look
                    Console.WriteLine($"Your estimated total for shipping this package is: ${totalEstimate:N2}");
                    Console.WriteLine("Thank you!");
                }
            }
            // Pause before closing
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
