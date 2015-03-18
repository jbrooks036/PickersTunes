using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PickersTunes.Models;
namespace TestPickers
{
    [TestClass]
    public class TuneModelTest
    {
        /*
        [TestMethod]
        public void CreatingATuneStoresItInTunes()
        {
        Tune LittleMaggie = new Tune("LittleMaggie");
        CollectionAssert.Contains(Tune.Tunes, LittleMaggie);
        }
        */
        [TestMethod]
        public void CreatingATuneStoresItsProperties()
        {
            PickersTunes.Models.Tune LittleMaggie = new PickersTunes.Models.Tune("Little Maggie");
            Assert.AreEqual("Little Maggie", LittleMaggie.Name);
        }
    }
}