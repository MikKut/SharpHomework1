using EmployeeProfile.Models;

namespace EmployeeProfile.Helper
{
    internal static class EmployeeHelper
    {
        /// <summary>
        /// Checks employee name for validity.
        /// </summary>
        /// <param name="name">name of the person.</param>
        /// <returns>true when it is valid, otherwise - false.</returns>
        public static bool CheckEmployeeNameForValidity(string name)
        {
            return name != null && !name!.Any(char.IsDigit);
        }

        /// <summary>
        /// Checks department name for validity.
        /// </summary>
        /// <param name="departmentName">name of department.</param>
        /// <returns>true when it is valid,  otherwise - false.</returns>
        public static bool CheckDepartmentNameForValidity(string departmentName)
        {
            return departmentName != null && departmentName.Any(char.IsLetter) && departmentName.Any(char.IsDigit);
        }

        /// <summary>
        /// Gets salary depends on position.
        /// </summary>
        /// <param name="employeePosition">Enum that represents position with fixed salary.</param>
        /// <returns>Int salary.</returns>
        public static int GetSalaryDependsOnPosition(PositionWithFixedSalary employeePosition)
        {
            return (int)employeePosition;
        }
    }
}
