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
    public class CalculationsDeserializerTests // CalculationsDeserializerTests
    {
        [TestMethod]
        public void CorrectSqrtTestMethod()
        {
            // Arrange
            var input =
@"{
""CorectSqrt"": {
""operator"": ""sqrt"",
""value1"": 100
}
}";

            //Act
            var output = CalculationsDeserializer.Deserialize(input); 

            //Assert
            Assert.AreEqual(output["CorectSqrt"].Operation, OperationType.Sqrt);

            Assert.AreEqual(output["CorectSqrt"].value1, 100);

            Assert.AreEqual(output["CorectSqrt"].value2, 0);

            Assert.AreEqual(output.Count, 1);


        }

        [TestMethod]
        public void CorrectSubTestMethod()
        {
            // Arrange
            var input =
@"{
""CorectSub"": {
""operator"": ""sub"",
""value1"": 9,
""value2"": 9
}
}";

            //Act
            var output = CalculationsDeserializer.Deserialize(input);

            //Assert
            Assert.AreEqual(output["CorectSub"].Operation, OperationType.Sub);

            Assert.AreEqual(output["CorectSub"].value1, 9);

            Assert.AreEqual(output["CorectSub"].value2, 9);

            Assert.AreEqual(output.Count,1);

        }

        [TestMethod]
        public void CorrectAddTestMethod()
        {
            // Arrange
            var input =
@"{
""CorectAdd"": {
""operator"": ""add"",
""value1"": 10,
""value2"": 9
}
}";

            //Act
            var output = CalculationsDeserializer.Deserialize(input);

            //Assert
            Assert.AreEqual(output["CorectAdd"].Operation, OperationType.Add);

            Assert.AreEqual(output["CorectAdd"].value1, 10);

            Assert.AreEqual(output["CorectAdd"].value2, 9);

            Assert.AreEqual(output.Count, 1);

        }

        [TestMethod]
        public void CorrectMulTestMethod()
        {
            // Arrange
            var input =
@"{
""CorectMul"": {
""operator"": ""add"",
""value1"": 10,
""value2"": 9
}
}";

            //Act
            var output = CalculationsDeserializer.Deserialize(input);

            //Assert
            Assert.AreEqual(output["CorectMul"].Operation, OperationType.Add);

            Assert.AreEqual(output["CorectMul"].value1, 10);

            Assert.AreEqual(output["CorectMul"].value2, 9);

            Assert.AreEqual(output.Count, 1);

        }

        [TestMethod]
        public void IncorrectOperatorValueTestMethod()
        {
            // Arrange
            var input =
@"{
""CorectMul"": {
""operator"": ""Incorect"",
""value1"": 10,
""value2"": 9
}
}";

            //Act
            var output = CalculationsDeserializer.Deserialize(input);

            //Assert

            Assert.AreEqual(output.Count, 0);

        }

        [TestMethod]
        public void IncorrectValue1ValueTestMethod()
        {
            // Arrange
            var input =
@"{
""CorectMul"": {
""operator"": ""add"",
""value1"": ""z"",
""value2"": 9
}
}";

            //Act
            var output = CalculationsDeserializer.Deserialize(input);

            //Assert

            Assert.AreEqual(output.Count, 0);

        }

        [TestMethod]
        public void IncorrectValue2ValueTestMethod()
        {
            // Arrange
            var input =
@"{
""CorectMul"": {
""operator"": ""add"",
""value1"": 10,
""value2"": ""z""
}
}";

            //Act
            var output = CalculationsDeserializer.Deserialize(input);

            //Assert

            Assert.AreEqual(output.Count, 0);

        }

        [TestMethod]
        public void IncorrectValue1MissingTestMethod()
        {
            // Arrange
            var input =
@"{
""CorectMul"": {
""operator"": ""add"",
""value2"": 9
}
}";

            //Act
            var output = CalculationsDeserializer.Deserialize(input);

            //Assert

            Assert.AreEqual(output.Count, 0);

        }

        [TestMethod]
        public void IncorrectValue2MissingTestMethod()
        {
            // Arrange
            var input =
@"{
""CorectMul"": {
""operator"": ""add"",
""value1"": 10
}
}";

            //Act
            var output = CalculationsDeserializer.Deserialize(input);

            //Assert

            Assert.AreEqual(output.Count, 0);

        }

        [TestMethod]
        public void IncorrectOperatorNameTestMethod()
        {
            // Arrange
            var input =
@"{
""CorectMul"": {
""Incorect"": ""add"",
""value1"": 10,
""value1"": 10
}
}";

            //Act
            var output = CalculationsDeserializer.Deserialize(input);

            //Assert

            Assert.AreEqual(output.Count, 0);

        }

        [TestMethod]
        public void IncorrectSingleFieldTestMethod()
        {
            // Arrange
            var input =
@"{
""CorectMul"": ""Test""
}";

            //Act
            var output = CalculationsDeserializer.Deserialize(input);

            //Assert

            Assert.AreEqual(output.Count, 0);

        }

        [TestMethod]
        public void IncorrectSqrtNaNTestMethod()
        {
            // Arrange
            var input =
@"{
""CorectSqrt"": {
""operator"": ""sqrt"",
""value1"": -100
}
}";

            //Act

            var output = CalculationsDeserializer.Deserialize(input);

            //Assert

            Assert.AreEqual(output.Count, 0);

        }
    }
}
