// <copyright file="EmployeeTest.cs">Copyright ©  2013</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PexDemo;

namespace PexDemo
{
    /// <summary>This class contains parameterized unit tests for Employee</summary>
    [PexClass(typeof(Employee))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class EmployeeTest
    {
        /// <summary>Test stub for CalculateSalary(Int32)</summary>
        [PexMethod]
        public decimal CalculateSalary([PexAssumeUnderTest]Employee target, int experience)
        {
            decimal result = target.CalculateSalary(experience);
            return result;
            // TODO: add assertions to method EmployeeTest.CalculateSalary(Employee, Int32)
        }

        //[PexMethod]
        //[PexArguments(-2)]
        //public void CalcualteSalary(int experience)
        //{
        //    var sut = new Employee();

        //    var result = sut.CalculateSalary(experience);

        //    Assert.AreEqual(1000.00m, result);
        //}
    }
}
