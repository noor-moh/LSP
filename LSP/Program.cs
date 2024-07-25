﻿using System;
using EmployeeLib;

namespace LSP {
    internal class Program {
        static void Main(string[] args) {
            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            EmployeeBase emp = new CEO();

            emp.FirstName = "Tom";
            emp.LastName = "Lally";
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
