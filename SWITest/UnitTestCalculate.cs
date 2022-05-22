using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWI;
using SWI.Logic;
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
            testcalc.OperationType = SWI.ENUM.OperationTypes.sqrt;
            testcalc.value1 = 100;
            testcalc.value2 = 0;

            Calculation correctLastValue = new Calculation();
            correctLastValue.OperationType = SWI.ENUM.OperationTypes.add;
            correctLastValue.value1 = 700;
            correctLastValue.value2 = 100;

            Calculation corectSqrt = new Calculation();
            corectSqrt.OperationType = SWI.ENUM.OperationTypes.sqrt;
            corectSqrt.value1 = 9;
            corectSqrt.value2 = 0;

            data.Add("test", testcalc);
            data.Add("CorrectLastValue", correctLastValue);
            data.Add("CorectSqrt", corectSqrt);

            Dictionary<string, double> expected = new Dictionary<string, double>();
            expected.Add("test", 10);
            expected.Add("CorrectLastValue", 800);
            expected.Add("CorectSqrt", 3);


            //Act
            Calculete calc = new Calculete(data);
            Dictionary<string, double> result = calc.DoCalculate();


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
                Assert.Fail();
            }

        }
    }
}
