using Mindbox;

namespace MindboxTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetAreaTest()
        {
            double radius = 10.5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Assert.AreEqual(expectedArea, new Circle { Radius = radius, }.GetArea(), "error: area");
        }
        [TestMethod]
        public void PositivityTest()
        {
            double radius = -10.5;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle 
            { 
                Radius = radius, 
            });
        }
    }
}