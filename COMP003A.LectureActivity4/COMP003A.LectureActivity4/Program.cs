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
        }
    }
}
