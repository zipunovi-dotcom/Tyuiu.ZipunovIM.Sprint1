namespace Tyuiu.ZipunovIM.Sprint1.Task0.V10.Test;
using Tyuiu.ZipunovIM.Sprint1.Task0.V10.Lib;


    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
          
        }

        [Test]
        public void ValidExpression()
        {
            
            DataService ds = new DataService();

         
            var res = ds.Calculate();

            
            Assert.AreEqual(-10.5, res);
        }
    }

