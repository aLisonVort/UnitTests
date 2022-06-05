using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalcAddDataProvider : IEnumerable<TestCaseData>
    {
        public IEnumerator<TestCaseData> GetEnumerator()
        {
            yield return new TestCaseData("13", "17", "30");
            yield return new TestCaseData("15.7", "77.1", "92,8");
            yield return new TestCaseData("-14", "-17", "-31");

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class CalcMinusDataProvider : IEnumerable<TestCaseData>
    {
        public IEnumerator<TestCaseData> GetEnumerator()
        {
            yield return new TestCaseData("13", "17", "-4");
            yield return new TestCaseData("18.99", "77.1", "-58,11");
            yield return new TestCaseData("1097684", "99.3", "1097584,7");

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class CalcDivideDataProvider : IEnumerable<TestCaseData>
    {
        public IEnumerator<TestCaseData> GetEnumerator()
        {
            yield return new TestCaseData("18", "3", "6");
            yield return new TestCaseData("150", "40", "3,75");

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class CalcMultiplyDataProvider : IEnumerable<TestCaseData>
    {
        public IEnumerator<TestCaseData> GetEnumerator()
        {
            yield return new TestCaseData("15", "66", "990");
            yield return new TestCaseData("5.3", "99.6", "527,88");
            yield return new TestCaseData("3", "100", "300");

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    public class CalcParseDataProvider : IEnumerable<TestCaseData>
    {
        public IEnumerator<TestCaseData> GetEnumerator()
        {
            yield return new TestCaseData("1.44", 1.44);
            yield return new TestCaseData("2", 2);
            yield return new TestCaseData("-142523.44", -142523.44);
            yield return new TestCaseData("0", 0);

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
