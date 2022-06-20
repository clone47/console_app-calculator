using CalculatorLibrary;

namespace CalculatorUnitTest
{
    public class UnitTest
    {
        [Theory]
        [MemberData(nameof(UnitTestDataForAdd.Data), MemberType = typeof(UnitTestDataForAdd))]
        public void Add(int value1, int value2, int expected)
        {
            Calculator calculator = new Calculator();
            string operationType = "a";

            var result = calculator.DoOperation(value1, value2, operationType);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(UnitTestDataForSubtract.Data), MemberType = typeof(UnitTestDataForSubtract))]
        public void Subtract(int value1, int value2, int expected)
        {
            Calculator calculator = new Calculator();
            string operationType = "s";

            var result = calculator.DoOperation(value1, value2, operationType);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(UnitTestDataForMultiply.Data), MemberType = typeof(UnitTestDataForMultiply))]
        public void Multiply(int value1, int value2, int expected)
        {
            Calculator calculator = new Calculator();
            string operationType = "m";

            var result = calculator.DoOperation(value1, value2, operationType);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(UnitTestDataForDivide.Data), MemberType = typeof(UnitTestDataForDivide))]
        public void Divide(int value1, int value2, int expected)
        {
            Calculator calculator = new Calculator();
            string operationType = "d";

            var result = calculator.DoOperation(value1, value2, operationType);
            Assert.Equal(expected, result);
        }
    }

    public class UnitTestDataForAdd
    {
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { 1, 2, 3 },
                new object[] { -4, -2, -6 },
            };
    }

    public class UnitTestDataForSubtract
    {
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { 2, 1, 1 },
            };
    }

    public class UnitTestDataForMultiply
    {
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { 2, 1, 2 },
            };
    }

    public class UnitTestDataForDivide
    {
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { 4, 2, 2 },
            };
    }
}