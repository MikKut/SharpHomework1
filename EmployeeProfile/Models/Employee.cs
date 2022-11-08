using EmployeeProfile.Helper;

namespace EmployeeProfile.Models
{
    /// <summary>
    /// Class that describes employee.
    /// </summary>
    internal class Employee : IEmployee
    {
        private DateTime _lastTimeWhenSalaryWasRecieved;
        private List<PositionWithFixedSalary> _historyOfPositions;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">Name of the employee(without digits).</param>
        /// <param name="employeePosition">Position and slary of the employee.</param>
        /// <param name="departmentName">Department name that must contain at least one digit and one letter.</param>
        /// <exception cref="ArgumentException">throws exception when the input data invalid.</exception>
        public Employee(string name, PositionWithFixedSalary employeePosition, string departmentName)
        {
            if (!(EmployeeHelper.CheckDepartmentNameForValidity(departmentName) && EmployeeHelper.CheckEmployeeNameForValidity(name)))
            {
                throw new ArgumentException($"Wrong input data for the employee {name}");
            }

            Name = name;
            EmployeePosition = employeePosition;
            DepartmentName = departmentName;
            Salary = EmployeeHelper.GetSalaryDependsOnPosition(employeePosition);
            _historyOfPositions = new List<PositionWithFixedSalary>();
            _historyOfPositions.Add(employeePosition);
            _lastTimeWhenSalaryWasRecieved = DateTime.Now;
        }

        /// <inheritdoc/>
        public decimal Salary { get; private set; }

        /// <inheritdoc/>
        public string DepartmentName { get; private set; }

        /// <inheritdoc/>
        public string Name { get; private set; }

        /// <inheritdoc/>
        public PositionWithFixedSalary EmployeePosition { get; private set; }

        /// <inheritdoc/>
        public bool TryChangePosition(PositionWithFixedSalary position)
        {
            if (_historyOfPositions.Last() == position)
            {
                return false;
            }

            _historyOfPositions.Add(position);
            EmployeePosition = position;
            return true;
        }

        /// <inheritdoc/>
        public bool CheckIfPersonWasInThePosition(PositionWithFixedSalary position)
        {
            foreach (var positionWithFixedSalary in _historyOfPositions)
            {
                if (positionWithFixedSalary == position)
                {
                    return true;
                }
            }

            return false;
        }

        /// <inheritdoc/>
        public bool ComparePositions(Employee employee)
        {
            return EmployeePosition == employee.EmployeePosition;
        }

        /// <inheritdoc/>
        public bool TryGetSalary()
        {
            var monthWhenSalaryIsAvailable = _lastTimeWhenSalaryWasRecieved.AddMonths(1);
            if (monthWhenSalaryIsAvailable <= DateTime.Now)
            {
                _lastTimeWhenSalaryWasRecieved = monthWhenSalaryIsAvailable;

                // somehow sends money.
                return true;
            }

            return false;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} from {DepartmentName} department {EmployeePosition} position earns {Salary}";
        }
    }
}
