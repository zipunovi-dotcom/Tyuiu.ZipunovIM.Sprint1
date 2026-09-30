using NUnit.Framework;
using System;
using Tyuiu.ZipunovIM.Sprint1.Task6.V8.Lib;

namespace Tyuiu.ZipunovIM.Sprint1.Task6.V8.Test
{
    public class DataServiceTest
    {
        [Test]
        public void ValidMoveFirstLetterToEnd()
        {
            DataService ds = new DataService();

            string text = "hello world";
            string wait = "elloh orldw"; 

            string res = ds.MoveFirstLetterToEnd(text);

            Assert.That(res, Is.EqualTo(wait));
        }
    }
}