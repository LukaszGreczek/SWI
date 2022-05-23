using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWI;
using SWI.Enums;
using SWI.Logic;
using SWI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWITest
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void CorrectSqrtResultTestMethod()
        {
            //Arrange
            Calculation CorrectSqrt = new Calculation();
            CorrectSqrt.Operation = OperationType.Sqrt;
            CorrectSqrt.value1 = 100;
            CorrectSqrt.value2 = 0;

            //Act
            double result = CorrectSqrt.Calculate();

            //Assert
            Assert.AreEqual(result,10);
        }

        [TestMethod]
        public void CorrectSubResultTestMethod()
        {
            //Arrange
            Calculation CorrectSub = new Calculation();
            CorrectSub.Operation = OperationType.Sub;
            CorrectSub.value1 = 100;
            CorrectSub.value2 = 10;

            //Act
            double result = CorrectSub.Calculate();

            //Assert
            Assert.AreEqual(result, 90);
        }


        [TestMethod]
        public void CorrectAddResultTestMethod()
        {
            //Arrange
            Calculation CorrectAdd = new Calculation();
            CorrectAdd.Operation = OperationType.Add;
            CorrectAdd.value1 = 100;
            CorrectAdd.value2 = 10;

            //Act
            double result = CorrectAdd.Calculate();

            //Assert
            Assert.AreEqual(result, 110);
        }

        [TestMethod]
        public void CorrectMulResultTestMethod()
        {
            //Arrange
            Calculation CorrectMul = new Calculation();
            CorrectMul.Operation = OperationType.Mul;
            CorrectMul.value1 = 100;
            CorrectMul.value2 = 10;

            //Act
            double result = CorrectMul.Calculate();

            //Assert
            Assert.AreEqual(result, 1000);
        }

        [TestMethod]
        public void IncorrectSqrtResultTestMethod()
        {
            //Arrange
            Calculation IncorrectMul = new Calculation();
            IncorrectMul.Operation = OperationType.Sqrt;
            IncorrectMul.value1 = -100;

            //Act
            double result = IncorrectMul.Calculate();

            //Assert
            Assert.AreEqual(result, double.NaN);
        }
    }
}
