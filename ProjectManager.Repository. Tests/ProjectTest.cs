using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectManager.Repository.Models;

namespace ProjectManager.Repository.Tests
{
    [TestClass]
    public class ProjectTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime Date = new DateTime(2019, 12, 01);
                    
            var Proj = new Project();
            Proj.Id = 10;
            Proj.Name = "First";
            Proj.Employee = "Marshal Vitaly Zhukov";
            Proj.Status = "Done";
            Proj.FinBalance = 15000;
            Proj.FinIncome = 10000;
            Proj.FinOutcome = 12000;
            Proj.DateRun = Date;
            Proj.DateEnd = Date;

            Debug.Print($"{Proj.Id } \n{Proj.Name} \n{Proj.Employee} \n{Proj.Status} \n{Proj.FinBalance} \n{Proj.FinIncome} \n{Proj.FinOutcome} \n{Proj.DateRun} \n{Proj.DateEnd}");
        }
        
        
    }
}
