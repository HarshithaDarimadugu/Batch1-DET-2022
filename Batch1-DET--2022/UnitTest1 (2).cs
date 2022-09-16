namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                int divd = 100;
                int divisor = 5;
                int res;
                int expectedResult = 20;
                ConsoleAppmath.div.Divide(divd, divisor, out res);
                Assert.AreEqual(expectedResult, res);

            }
        }
    }
}