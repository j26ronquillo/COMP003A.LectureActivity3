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

            int number = 1;
                while ( number <= 6)
            {
                number++;
                 if (number == 4)
                { //continue is used to skip an iteration and move on to the next number/step
                    continue;
                }
                 if (number == 6)
                { // break is used to stop/terminate a loop even if the condition is still true
                    break;
                }
                Console.WriteLine($"{number}");
            }
                // 1. The for loop was easiest to understand because I was able to create all the
                // and laws in a single line, making it easier to understand.

                // 2. The while loop probably requires the most careful tracing because you can accidently
                // create an infinite loop if not made an exit line.

                // 3. The comments helped me understand the different loops because it show me the specific
                // lines that created, terminated, and evaluated in the loop process.
        }
    }
}
