using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProfile.Models
{
    /// <summary>
    /// Represents position and salary of an employee
    /// </summary>
    internal enum PositionWithFixedSalary
    {
        Handyman = 5_000,
        Engineer = 10_000,
        Manager = 20_000,
        Director = 50_000,
    }
}
