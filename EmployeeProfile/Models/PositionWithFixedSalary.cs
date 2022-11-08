using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProfile.Models
{
    /// <summary>
    /// Represents position and salary of an employee.
    /// </summary>
    internal enum PositionWithFixedSalary
    {
        /// <summary>
        /// Handyman with 5 000 salary
        /// </summary>
        Handyman = 5_000,

        /// <summary>
        /// Engineer with 10 000 salary
        /// </summary>
        Engineer = 10_000,

        /// <summary>
        /// Manager with 20 000 salary
        /// </summary>
        Manager = 20_000,

        /// <summary>
        /// Director with 50 000 salary
        /// </summary>
        Director = 50_000,
    }
}
