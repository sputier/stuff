using System;
using DecimalToRoman;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecimalToRoman.Tests
{
    [TestClass]
    public class DecimalToRomanConverterTests
    {
        [TestMethod]
        public void Convert_Should_Return_Correct_Result()
        {
            var testData = new []
            {
                (input: 1, output: "I"),
                (input: 5, output: "V"),
                (input: 7, output: "VII"),
                (input: 9, output: "IX"),
                (input: 42, output: "XLII"),
                (input: 354, output: "CCCLIV"),
                (input: 1492, output: "MCDXCII"),
                (input: 1999, output: "MCMXCIX"),
                (input: 2019, output: "MMXIX"),
                (input: 4888, output: "MMMMDCCCLXXXVIII"),
            };

            var converter = new DecimalToRomanConverter();
            foreach (var data in testData)
            {
                Assert.AreEqual(data.output, converter.Convert(data.input));
            }
        }
    }
}
