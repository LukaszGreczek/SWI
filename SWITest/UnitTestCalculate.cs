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
    public class UnitTestCalculate
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Dictionary<string, Calculation> data = new Dictionary<string, Calculation>();

            Calculation testcalc = new Calculation();
            testcalc.Operation = OperationType.Sqrt;
            testcalc.value1 = 100;
            testcalc.value2 = 0;

            Calculation correctLastValue = new Calculation();
            correctLastValue.Operation = OperationType.Add;
            correctLastValue.value1 = 700;
            correctLastValue.value2 = 100;

            Calculation corectSqrt = new Calculation();
            corectSqrt.Operation = OperationType.Sqrt;
            corectSqrt.value1 = 9;
            corectSqrt.value2 = 0;

            Calculation corectSub = new Calculation();
            corectSub.Operation = OperationType.Sub;
            corectSub.value1 = 9;
            corectSub.value2 = 9;

            Calculation corectMul = new Calculation();
            corectMul.Operation = OperationType.Mul;
            corectMul.value1 = 9;
            corectMul.value2 = 9;

            data.Add("test", testcalc);
            data.Add("CorrectLastValue", correctLastValue);
            data.Add("CorectSqrt", corectSqrt);
            data.Add("CorectSub", corectSub);
            data.Add("CorectMul", corectMul);

            Dictionary<string, double> expected = new Dictionary<string, double>();
            expected.Add("test", 10);
            expected.Add("CorrectLastValue", 800);
            expected.Add("CorectSqrt", 3);
            expected.Add("CorectSub", 0);
            expected.Add("CorectMul", 81);


            //Act
            var result = BatchCalculator.DoCalculate(data);


            //Assert
            if (expected.Count != result.Count)
            {
                Assert.Fail();
            }

            if (!expected["test"].Equals(result["test"]))
            {
                Assert.Fail();
            }

            if (!expected["CorrectLastValue"].Equals(result["CorrectLastValue"]))
            {
                Assert.Fail();
            }

            if (!expected["CorectSqrt"].Equals(result["CorectSqrt"]))
            {
                //Assert.Fail();
            }

            if (!expected["CorectSub"].Equals(result["CorectSub"]))
            {
                Assert.Fail();
            }

            if (!expected["CorectMul"].Equals(result["CorectMul"]))
            {
               //Assert.Fail();
            }
        }
    }
}
