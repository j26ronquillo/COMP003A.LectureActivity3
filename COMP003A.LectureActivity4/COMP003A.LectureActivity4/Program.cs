using System.Diagnostics.Metrics;

namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taskNumber = 1;

            while (taskNumber <= 5)
            { Console.WriteLine($"Task {taskNumber} completed");
                taskNumber++; 
            }
           
            //this loop executes atleast once because the condition is checked
            //at the end of the loop, so the code inside the block runs before
            //the actual loop condition is evaluated and ultimately continues
            int attempt = 1;
            do
            {
                Console.WriteLine($"Attempt {attempt}");
                attempt++;
            }
            while ( attempt <= 3);

            //the for loop is used here because the number of reps is set and known in advance
            int stepNumber = 1;
            for (stepNumber = 1;  stepNumber <= 4; stepNumber++)
            { Console.WriteLine($"Step {stepNumber} "); }
        }
    }
}
