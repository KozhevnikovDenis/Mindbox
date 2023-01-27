using Mindbox;

namespace MindboxTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetAreaTest()
        {
            double sideA = 10.5;
            double sideB = 10.5;
            double sideC = 10.5;
            double perimeter = sideA + sideB + sideC;
            double expectedArea = Math.Sqrt(0.5 * perimeter * (0.5 * perimeter - sideA) * (0.5 * perimeter - sideA) * (0.5 * perimeter - sideA));
            Triangle t = new Triangle
            {
                SideA = sideA,
                SideB = sideB,
                SideC = sideC,
            };
            Assert.AreEqual(expectedArea, t.GetArea(), "error area");
        }
        [TestMethod]
        public void PositivityTest()
        {
            double sideA = -10.5;
            double sideB = -10.5;
            double sideC = -10.5;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle
            {
                SideA = sideA,
                SideB = sideB,
                SideC = sideC,
            });
        }
        [TestMethod]
        public void ExistenceTest()
        {
            double sideA = 0.5;
            double sideB = 0.5;
            double sideC = 10.5;
            Assert.ThrowsException<ArgumentException>(() => new Triangle 
            { 
                SideA = sideA, 
                SideB = sideB, 
                SideC = sideC, 
            }.GetArea());
        }
    }
}
