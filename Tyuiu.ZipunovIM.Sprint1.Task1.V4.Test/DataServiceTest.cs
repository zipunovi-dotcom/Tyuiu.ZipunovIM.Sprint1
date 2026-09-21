namespace Tyuiu.ZipunovIM.Sprint1.Task1.V4.Test;
    using Tyuiu.ZipunovIM.Sprint1.Task1.V4.Lib;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidExpression ()
    {
        DataService ds = new DataService();
        double x = 2.0;
        double y = 2.0;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(4.0, res);
    }
}
