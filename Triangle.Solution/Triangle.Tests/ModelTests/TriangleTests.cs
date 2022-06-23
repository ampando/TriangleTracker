using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TrackerTests
  {
    [TestMethod]
    public void IsTriangle_OneSideSumGreaterThanSumOfOtherTwoSides_True()
    {
      Tracker testSideSums = new Tracker();
      Assert.AreEqual(false, testSideSums.IsTriangle(1, 2, 3));
    }
  }
}