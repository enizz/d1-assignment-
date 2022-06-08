using System;

namespace Deliverable1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Each sandwhich requires 2 slices of bread, 2 tablespoons of peanut butter, and 4 teaspoons of jelly
            // Assume 1 sandwich per person
            // Assume 1 loaf of bread contains exactly 28 slices
            // Assume 1 jar of peanut butter contains exactly 32 tablespoons
            // Assume 1 jar of jelly contains exactly 48 teaspoons



            Console.WriteLine("How many people are we making PB&J sandwiches for? ");


            // Converted string to int
            
            int invitees = Convert.ToInt32(Console.ReadLine());

            // Calculations

            decimal totalSlicesNeeded = invitees * 2;
            decimal totaltbls = invitees * 2;
            decimal totaltsp = invitees * 4;

            decimal rLoavesNeeded = Math.Ceiling(totalSlicesNeeded / 28);
            decimal rJellyJars = Math.Ceiling(totaltsp / 48);
            decimal rPBJars = Math.Ceiling(totaltbls / 32);


           
            Console.WriteLine("# of invitees: " + invitees);
            Console.WriteLine("total slices needed: " + totalSlicesNeeded);
            Console.WriteLine("total tablespoons of peanut butter needed: " + totaltbls);
            Console.WriteLine("total teaspoons of jelly needed: " + totaltsp);
            Console.WriteLine();
            Console.WriteLine("which means you'll need:");
            Console.WriteLine();
            Console.WriteLine(rLoavesNeeded + " loaves of bread");
            Console.WriteLine(rJellyJars + " jars of jelly");
            Console.WriteLine(rPBJars + " jars of peanut butter");
            Console.WriteLine();
            Console.WriteLine("Would you like to restart? Enter 'yes' or 'y' to continue, any other key to exit.");

            string answer = Console.ReadLine();

            if (answer == "yes" || answer == "y") { Main(args); }
            else
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
        }
    }
}