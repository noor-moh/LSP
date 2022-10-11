using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib
{
    public interface IHaveManager<T>
    {
        EmployeeBase Manager { get; set; }
        void AssignManager(T manager);
    }
}
