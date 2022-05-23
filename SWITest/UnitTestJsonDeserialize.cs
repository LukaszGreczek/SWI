using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWI.IO;
using SWI.Logic;
using System.Collections.Generic;
using SWI.Models;
using SWI.Enums;
using SWI.Interfaces;

namespace SWITest
{
    [TestClass]
    public class UnitTestJsonDeserialize
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            const string inputFilePath = "input.json";
            Dictionary<string, Calculation> expected = new Dictionary<string, Calculation>();

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

            expected.Add("test", testcalc);
            expected.Add("CorrectLastValue", correctLastValue);
            expected.Add("CorectSqrt", corectSqrt);
            expected.Add("CorectSub", corectSub);
            expected.Add("CorectMul", corectMul);

            IInputDataReader iReader = new TextFileInputDataReader(inputFilePath);

            //Act
            CalculationsDeserializer jsonDeserialize = new CalculationsDeserializer(iReader.ReadData());
            Dictionary<string, Calculation> result = jsonDeserialize.ReturnCalculations();

            //Assert
            if(expected.Count != result.Count)
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

            if (!expected["CorectSub"].Equals(result["CorectSub"]))
            {
                Assert.Fail();
            }


            if (!expected["CorectMul"].Equals(result["CorectMul"]))
            {
                Assert.Fail();
            }

        }
    }
}
