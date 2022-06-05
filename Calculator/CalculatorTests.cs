using FluentAssertions;
using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    public class CalculatorTests
    {
        private CalculatorForm Form;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Form = new CalculatorForm();
        }

        [TestCaseSource(typeof(CalcAddDataProvider))]
        public void AddFunc(string number1, string number2, string expctedResult)
        {
           string sum = Form.AddOperation(number1, number2);
            sum.Should().Be(expctedResult);
        }


        [TestCaseSource(typeof(CalcMinusDataProvider))]
        public void MinusFunc(string number1, string number2, string expctedResult)
        {
            string sum = Form.MinusOperation(number1, number2);
            sum.Should().Be(expctedResult);
        }


        [TestCaseSource(typeof(CalcMultiplyDataProvider))]
        public void MultiplyFunc(string number1, string number2, string expctedResult)
        {
            string sum = Form.MultiplyOperation(number1, number2);
            sum.Should().Be(expctedResult);
        }


        [TestCaseSource(typeof(CalcDivideDataProvider))]
        public void DivideFunc(string number1, string number2, string expctedResult)
        {
            string sum = Form.DivideOperation(number1, number2);
            sum.Should().Be(expctedResult);
        }

        [TestCaseSource(typeof(CalcParseDataProvider))]
        public void ParseFunc(string valueToParse,double expctedResult)
        {
            double parsed = Form.ParseString(valueToParse);
            parsed.Should().Be(expctedResult);
        }
    }
}
