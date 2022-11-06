
using EmployeeProfile.Models;

namespace EmployeeProfile
{
    class Program
    {
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
                    Console.WriteLine($"{employee1.Name} is euqal to {employee2.Name}");
                }
                if (employee1.TryChangePosition(PositionWithFixedSalary.Engineer))
                {
                    Console.WriteLine(employee1.ToString());
                }
                if (!employee1.ComparePositions(employee2))
                {
                    Console.WriteLine($"{employee1.Name} is not euqal to {employee2.Name}");
                }
                Console.WriteLine(employee2.TryGetSalary());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}