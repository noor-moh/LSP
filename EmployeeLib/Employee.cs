using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib
{
    public abstract class Employee : EmployeeBase, IHaveManager<Manager>
    {

        public EmployeeBase Manager { get; set; }
        public void AssignManager(Manager manager)
        {
            // Simulate doing other tasks here - otherwise, this should be
            // a property set statement, not a method.

            Manager = manager;
        }
    }
}
