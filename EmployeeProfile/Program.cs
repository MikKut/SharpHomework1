using EmployeeProfile.Models;

namespace EmployeeProfile
{
    /// <summary>
    /// Class with entry point.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry point to the program.
        /// </summary>
        public static void Main()
        {
            try
            {
                var employee1 = new Employee("Mikkie", PositionWithFixedSalary.Handyman, "Department1");
                var employee2 = new Employee("Mikkie", PositionWithFixedSalary.Handyman, "Department1");
                var employee3 = new Employee("Alex", PositionWithFixedSalary.Handyman, "Department1");
                Console.WriteLine(employee1.ToString());
                if (employee1.ComparePositions(employee2))
                {
                    Console.WriteLine($"{employee1.Name} {employee1.EmployeePosition} is euqal to {employee2.Name} {employee2.EmployeePosition}");
                }

                if (employee1.TryChangePosition(PositionWithFixedSalary.Engineer))
                {
                    Console.WriteLine(employee1.ToString());
                }

                if (!employee1.ComparePositions(employee2))
                {
                    Console.WriteLine($"{employee1.Name} {employee1.EmployeePosition} is not euqal to {employee2.Name} {employee2.EmployeePosition}");
                }

                Console.WriteLine("The newbie can recieve a salary: " + employee2.TryGetSalary());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}