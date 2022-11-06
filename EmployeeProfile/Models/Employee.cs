using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProfile.Models
{
    internal class Employee
    {
        private DateTime _lastTimeWhenSalaryWasRecieved;
        private List<PositionWithFixedSalary> historyOfPositions;
        public decimal Salary { get; private set; }
        public string DepartmentName { get; private set; }
        public string Name { get; private set; }
        public PositionWithFixedSalary EmployeePosition { get; private set; }
        public Employee(string name, PositionWithFixedSalary employeePosition, string departmentName)
        {
            if (!(CheckDepartmentNameForValidity(departmentName) && CheckEmployeeNameForValidity(name)))
            {
                throw new ArgumentException($"Wrong input data for the employee {name}");
            }

            Name = name;
            EmployeePosition = employeePosition;
            DepartmentName = departmentName;
            Salary = GetSalaryDependsOnPosition(employeePosition);
            historyOfPositions = new List<PositionWithFixedSalary>();
            historyOfPositions.Add(employeePosition);
            _lastTimeWhenSalaryWasRecieved = DateTime.Now;
        }

        public bool TryChangePosition(PositionWithFixedSalary position)
        {
            if (historyOfPositions.Last() == position )
            {
                return false;
            }

            historyOfPositions.Add(position);
            EmployeePosition = position;
            return true;
        }

        public bool ThePersonWasInThePosition(PositionWithFixedSalary position)
        {
            foreach (var positionWithFixedSalary in historyOfPositions)
            {
                if (positionWithFixedSalary == position)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Comapres positions of two employees for equality.
        /// </summary>
        /// <param name="employee">Employee to compare</param>
        /// <returns>true if equal, otherwise - false</returns>
        public bool ComparePositions(Employee employee)
        {
            return this.EmployeePosition == employee.EmployeePosition;
        }
        public bool TryGetSalary()
        {
            var monthWhenSalaryIsAvailable = _lastTimeWhenSalaryWasRecieved.AddMonths(1);
            if (monthWhenSalaryIsAvailable <= DateTime.Now)
            {
                _lastTimeWhenSalaryWasRecieved = monthWhenSalaryIsAvailable;
                //sends money
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{Name} from {DepartmentName} department {EmployeePosition} position earns {Salary}";
        }

        /// <summary>
        /// Checks employee name for validity
        /// </summary>
        /// <param name="employeePosition">name of the person</param>
        /// <returns>true when it is valid, otherwise - false</returns>
        private bool CheckEmployeeNameForValidity(string name)
        {
            return name != null && !name!.Any(char.IsDigit);
        }

        /// <summary>
        /// Checks department name for validity
        /// </summary>
        /// <param name="departmentName">name of department</param>
        /// <returns>true when it is valid,  otherwise - false</returns>
        private bool CheckDepartmentNameForValidity(string departmentName)
        {
            return departmentName != null && departmentName.Any(char.IsLetter) && departmentName.Any(char.IsDigit);
        }

        private int GetSalaryDependsOnPosition(PositionWithFixedSalary employeePosition)
        {
            return (int)employeePosition;
        }
    }
}
