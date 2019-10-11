using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectManager.Authentication.Models;

namespace ProjectManager.AuthTest
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var auth = new Login();
            auth.Email = "Pupka";
            auth.Name = "Lupka";
            Debug.Print($"{auth.Name} {auth.Email}");
        }
    }
}
