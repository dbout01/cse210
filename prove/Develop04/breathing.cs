public class BreathingActivity : Activity
{
    public BreathingActivity(int durationInSeconds) : base("Breathing Activity", "Relax by breathing in and out slowly. Clear your mind and focus on your breathing.", durationInSeconds)
    {
        // Additional setup for BreathingActivit
    }

    public void StartBreathingActivity()
    {
        DisplayStartingMessage();

        int secondsElapsed = 0;

        while (secondsElapsed < DurationInSeconds)
        {
            Console.WriteLine("Breathe in...");
            PauseWithCountdown(3); // Pauses for 3 seconds with countdown
            Console.WriteLine("Breathe out...");
            PauseWithCountdown(3); // Pauses for 3 seconds with countdown

            secondsElapsed += 6; // Each cycle takes 6 seconds (3 seconds inhale + 3 seconds exhale)
        }

        DisplayEndingMessage();
    }

    private void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"[{i}] ");
            System.Threading.Thread.Sleep(1000); // Pauses for 1 second
            Console.SetCursorPosition(Console.CursorLeft - 6, Console.CursorTop);
        }
        Console.WriteLine(); // Moves to the next line after the countdown
    }
}