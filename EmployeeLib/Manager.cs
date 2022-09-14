using System;

namespace EmployeeLib
{
    public class Manager : EmployeeBase, ISupervised
    {
        public EmployeeBase Supervisor { get; set; }

        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);
        }


        public void AssignManager(EmployeeBase manager)
        {
            // Simulate doing other tasks here - otherwise, this should be
            // a property set statement, not a method.

            Supervisor = manager;
        }
        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }
}
