using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWI;
using SWI.IO;
using SWI.INTERFACE;
using SWI.Logic;
using System.Collections.Generic;

namespace SWITest
{
    [TestClass]
    public class UnitTestJsonDeserialize
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Dictionary<string, Calculation> expected = new Dictionary<string, Calculation>();

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

            expected.Add("test", testcalc);
            expected.Add("CorrectLastValue", correctLastValue);
            expected.Add("CorectSqrt", corectSqrt);

            IReader iReader = new JsonFileReader();

            //Act
            JsonDeserialize jsonDeserialize = new JsonDeserialize(iReader.GetData());
            Dictionary<string, Calculation> result = jsonDeserialize.ReturnDicrionary();

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
        }
    }
}
