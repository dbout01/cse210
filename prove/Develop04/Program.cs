using System;

class Program
{
    static void Main()
    {
        int duration = 60; // Default duration in seconds

        while (true)
        {
            Console.WriteLine("Mindfulness Program Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (int.TryParse(choice, out int activityChoice))
            {
                switch (activityChoice)
                {
                    case 1:
                        BreathingActivity breathingActivity = new BreathingActivity(duration);
                        breathingActivity.StartBreathingActivity();
                        break;

                    case 2:
                        ReflectionActivity reflectionActivity = new ReflectionActivity(duration);
                        reflectionActivity.StartReflectionActivity();
                        break;

                    case 3:
                        ListingActivity listingActivity = new ListingActivity(duration);
                        listingActivity.StartListingActivity();
                        break;

                    case 4:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine(); // Adds a newline for better readability
        }
    }
}
