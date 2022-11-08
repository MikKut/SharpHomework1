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

        /// <summary>
        /// Compares position of two employees.
        /// </summary>
        /// <param name="employee">Employee to compare.</param>
        /// <returns>IF euqals - true, otherwise - false.</returns>
        bool ComparePositions(Employee employee);

        /// <summary>
        /// Checks whether the person was in the position.
        /// </summary>
        /// <param name="position">The position that is looked for.</param>
        /// <returns>If found - true, otherwise - false.</returns>
        bool CheckIfPersonWasInThePosition(PositionWithFixedSalary position);

        /// <summary>
        /// Represents employee`s position in company.Returns string that has all properties of the employee class.
        /// </summary>
        /// <returns>String representation of employee`s position in company.</returns>
        string ToString();

        /// <summary>
        /// Tries to change the position.
        /// </summary>
        /// <param name="position">Position to change.</param>
        /// <returns>False if position is the same current, otherwise - true.</returns>
        bool TryChangePosition(PositionWithFixedSalary position);

        /// <summary>
        /// Tries to give money to the employee.
        /// </summary>
        /// <returns>True if time allows to recieve money, otherwise - false.</returns>
        bool TryGetSalary();
    }
}