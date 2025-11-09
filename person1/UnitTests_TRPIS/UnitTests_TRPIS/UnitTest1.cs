namespace UnitTests_TRPIS
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 4, 3, 2, 1 };

            for (int i = 0; i < a.Length; i++)
                if (Program.Sum(a[i], b[i]) != a[i] + b[i])
                    Assert.Fail();

            Assert.Pass();
        }
    }
}