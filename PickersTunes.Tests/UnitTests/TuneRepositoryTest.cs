using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PickersTunes;
using PickersTunes.Models;
using PickersTunes.Repository;

namespace TestPickers
{
    /// <summary>
    /// Summary description for TuneRepositoryTest
    /// </summary>
    [TestClass]
    public class TuneRepositoryTest
    {
        private static TuneRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new TuneRepository();
            repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            repo.Clear();

        }

        [TestCleanup]
        public void ClearDatabase()
        {
            repo.Clear();
        }

        [TestMethod]
        public void TestAddToDatabase() // Valid
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new PickersTunes.Models.Tune("Little Maggie"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestAllMethod()
        {
            repo.Add(new PickersTunes.Models.Tune("Little Maggie"));
            repo.Add(new PickersTunes.Models.Tune("Foggy Mountain Breakdown"));
            Assert.AreEqual(2, repo.GetCount());
        }

        [TestMethod]
        public void TestGetByTuneName()
        {
            repo.Add(new PickersTunes.Models.Tune("Little Maggie"));
            repo.Add(new PickersTunes.Models.Tune("Foggy Mountain Breakdown"));
            repo.Add(new PickersTunes.Models.Tune("Boil dem Cabbage Down"));
            var t = repo.GetByTuneName("Little Maggie")[0];
            Assert.AreEqual(t.Name, "Little Maggie");
        }

        [TestMethod]
        public void TestGetCount()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new PickersTunes.Models.Tune("Little Maggie"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestClear()
        {
            repo.Add(new PickersTunes.Models.Tune("Little Maggie"));
            repo.Clear();
            Assert.AreEqual(0, repo.GetCount());
        }
    }
}