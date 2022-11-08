namespace EmployeeProfile.Models
{
    internal interface IEmployee
    {
        /// <summary>
        /// Gets department name of the employee.
        /// </summary>
        /// <value>
        /// Department name of the employee.
        /// </value>
        string DepartmentName { get; }

        /// <summary>
        /// Gets name of the employee.
        /// </summary>
        /// <value>
        /// Name of the employee.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets salary of the employee.
        /// </summary>
        /// <value>
        /// Salary of the employee.
        /// </value>
        decimal Salary { get; }

        /// <summary>
        /// Gets employee position of the employee.
        /// </summary>
        /// <value>
        /// Employee position of the employee.
        /// </value>
        PositionWithFixedSalary EmployeePosition { get; }

        bool ComparePositions(Employee employee);
        bool ThePersonWasInThePosition(PositionWithFixedSalary position);
        string ToString();
        bool TryChangePosition(PositionWithFixedSalary position);
        bool TryGetSalary();
    }
}