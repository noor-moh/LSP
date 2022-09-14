namespace EmployeeLib
{
    public abstract class EmployeeBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }

    public interface ISupervised
    {
        EmployeeBase Supervisor { get; set; }
        void AssignManager(EmployeeBase manager);
    }

    public class Employee : EmployeeBase, ISupervised
    {

        public EmployeeBase Supervisor { get; set; }
        public void AssignManager(EmployeeBase manager)
        {
            // Simulate doing other tasks here - otherwise, this should be
            // a property set statement, not a method.
            
            Supervisor = manager;
        }
    }
}
