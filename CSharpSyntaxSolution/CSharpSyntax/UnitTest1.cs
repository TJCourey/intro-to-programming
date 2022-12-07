namespace CSharpSyntax
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void TestingTheAdditionOperator()
        {
            int a = 10, b = 20, answer;

            answer = a + b;

            Assert.Equal(30, answer);
        }
        [Theory]
        [InlineData(10, 20, 30)]
        [InlineData(5, 20,25)]
        [InlineData(7, 8, 15)]

        public void CanAddAnyTwo(int a, int b, int expected)
        {
            int answer = a + b;

            Assert.Equal(expected, answer);
        }
    }
}