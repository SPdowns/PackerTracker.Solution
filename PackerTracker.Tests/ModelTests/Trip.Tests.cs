using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;

namespace PackerTracker.Tests
{
  [TestClass]
  public class TripTests
  {

    [TestMethod]
    public void Trip_InstantiateTripObj_True()
    {
      Trip testTrip = new Trip();
      Assert.AreEqual(typeof(Trip), testTrip.GetType());
    }

  }
}