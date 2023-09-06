namespace P20.ExamTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            string arrivalCondition = string.Empty;

            int totalExamMin = examMin + examHour * 60;
            int totalArrivalMin = arrivalMin + arrivalHour * 60;

            if (totalArrivalMin > totalExamMin)
            {
                arrivalCondition = "Late";
            }
            else if (totalExamMin - totalArrivalMin <= 30)
            {
                arrivalCondition = "On time";
            }
            else
            {
                arrivalCondition = "Early";
            }

            Console.WriteLine(arrivalCondition);

            int minDiff = Math.Abs(totalArrivalMin - totalExamMin);

            int hourLate = minDiff / 60;
            int minLate = minDiff % 60;

            string timeResult = string.Empty;

            if (hourLate != 0)
            {
                timeResult = $"{hourLate}:{minLate:D2} hours";
            }
            else if (minLate != 0)
            {
                timeResult = $"{minLate} minutes";
            }

            if (arrivalCondition == "Late")
            {
                timeResult += " after the start";
            }
            else if (arrivalCondition == "Early" || (arrivalCondition == "On time" && minLate != 0))
            {
                timeResult += " before the start";
            }

            Console.WriteLine(timeResult);
        }
    }
}