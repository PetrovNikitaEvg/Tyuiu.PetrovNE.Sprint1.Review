using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint1.TaskReview.V24.Lib;

namespace Tyuiu.PetrovNE.Sprint1.TaskReview.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1, y = 1;
            double res = -1.156;
            Assert.AreEqual(res, ds.Calculate(x, y));
        }
    }
}
