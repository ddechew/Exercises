using System;

namespace P07.ProjectCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string archiName = Console.ReadLine();
            byte projectsCount = byte.Parse(Console.ReadLine());
            ushort timeForProjects = (ushort)(projectsCount * 3);

            Console.WriteLine($"The architect {archiName} will need {timeForProjects} hours to complete {projectsCount} project/s.");
        }
    }
}
