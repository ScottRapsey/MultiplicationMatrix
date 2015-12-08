using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplicationMatrixTests
{
    [TestClass]
    public class RawOutputGeneratorTests
    {
        [TestMethod]
        public void Test1To1()
        {
            var result = MultiplicationMatrix.RawOutputGenerator.GetMultiplicationMatrixString(1, 1);
            var expectedResult = "      001 \r\n 001  001 \r\n";
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Test1To2()
        {
            var result = MultiplicationMatrix.RawOutputGenerator.GetMultiplicationMatrixString(1, 2);
            var expectedResult = "      001  002 \r\n 001  001  002 \r\n 002  002  004 \r\n";
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Test1To12()
        {
            var result = MultiplicationMatrix.RawOutputGenerator.GetMultiplicationMatrixString(1, 12);
            var expectedResult = "      001  002  003  004  005  006  007  008  009  010  011  012 \r\n 001  001  002  003  004  005  006  007  008  009  010  011  012 \r\n 002  002  004  006  008  010  012  014  016  018  020  022  024 \r\n 003  003  006  009  012  015  018  021  024  027  030  033  036 \r\n 004  004  008  012  016  020  024  028  032  036  040  044  048 \r\n 005  005  010  015  020  025  030  035  040  045  050  055  060 \r\n 006  006  012  018  024  030  036  042  048  054  060  066  072 \r\n 007  007  014  021  028  035  042  049  056  063  070  077  084 \r\n 008  008  016  024  032  040  048  056  064  072  080  088  096 \r\n 009  009  018  027  036  045  054  063  072  081  090  099  108 \r\n 010  010  020  030  040  050  060  070  080  090  100  110  120 \r\n 011  011  022  033  044  055  066  077  088  099  110  121  132 \r\n 012  012  024  036  048  060  072  084  096  108  120  132  144 \r\n";
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestNegative1ToNegative1()
        {
            var result = MultiplicationMatrix.RawOutputGenerator.GetMultiplicationMatrixString(-1, -1);
            var expectedResult = "      -001 \r\n -001  001 \r\n";
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestNegative1To2()
        {
            var result = MultiplicationMatrix.RawOutputGenerator.GetMultiplicationMatrixString(-1, 2);
            var expectedResult = "      -001  000  001  002 \r\n -001  001  000  -001  -002 \r\n 000  000  000  000  000 \r\n 001  -001  000  001  002 \r\n 002  -002  000  002  004 \r\n";
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestNegative1To12()
        {
            var result = MultiplicationMatrix.RawOutputGenerator.GetMultiplicationMatrixString(-1, 12);
            var expectedResult = "      -001  000  001  002  003  004  005  006  007  008  009  010  011  012 \r\n -001  001  000  -001  -002  -003  -004  -005  -006  -007  -008  -009  -010  -011  -012 \r\n 000  000  000  000  000  000  000  000  000  000  000  000  000  000  000 \r\n 001  -001  000  001  002  003  004  005  006  007  008  009  010  011  012 \r\n 002  -002  000  002  004  006  008  010  012  014  016  018  020  022  024 \r\n 003  -003  000  003  006  009  012  015  018  021  024  027  030  033  036 \r\n 004  -004  000  004  008  012  016  020  024  028  032  036  040  044  048 \r\n 005  -005  000  005  010  015  020  025  030  035  040  045  050  055  060 \r\n 006  -006  000  006  012  018  024  030  036  042  048  054  060  066  072 \r\n 007  -007  000  007  014  021  028  035  042  049  056  063  070  077  084 \r\n 008  -008  000  008  016  024  032  040  048  056  064  072  080  088  096 \r\n 009  -009  000  009  018  027  036  045  054  063  072  081  090  099  108 \r\n 010  -010  000  010  020  030  040  050  060  070  080  090  100  110  120 \r\n 011  -011  000  011  022  033  044  055  066  077  088  099  110  121  132 \r\n 012  -012  000  012  024  036  048  060  072  084  096  108  120  132  144 \r\n";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestArgumentEx()
        {
            try
            {
                var result = MultiplicationMatrix.RawOutputGenerator.GetMultiplicationMatrixString(12, 1);
                Assert.Fail("Should have thrown and exception");
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
        }

    }
}
