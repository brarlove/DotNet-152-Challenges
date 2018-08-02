using System;
using Challenge3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_3_Test
{
    [TestClass]
    public class UnitTest3
    {
        Challenge3.Outing_Repository newOuting_Repository;
        [TestInitialize]
        public void Arrange()
        {
            newOuting_Repository = new Challenge3.Outing_Repository();
        }
        [TestMethod]
        public void Outing_Repository_addOutingToTheList_ShouldIncreaseCountByOne()
        {
            Outing Golf = new Outing("Golf", 5, DateTime.Parse("07/31/18"), 20.00, 100.00);
            newOuting_Repository.addOutingToTheList(Golf);

            var actual = newOuting_Repository.showListOfOuting().Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Outing_Respository_removeOutingFromTheList_ShouldDecreaseCountByOne()
        {
            Outing Golf = new Outing("Golf", 5, DateTime.Parse("07/31/18"), 20.00, 100.00);
            Outing Concert = new Outing("Concert", 5, DateTime.Parse("07/25/18"), 20.00, 100.00);
            Outing Park = new Outing("Park", 5, DateTime.Parse("07/10/18"), 20.00, 100.00);
            newOuting_Repository.addOutingToTheList(Golf);
            newOuting_Repository.addOutingToTheList(Concert);
            newOuting_Repository.addOutingToTheList(Park);

            newOuting_Repository.removeOutingFromTheList(Park);

            var actual = newOuting_Repository.showListOfOuting().Count;
            var expected = 2;

            Assert.AreEqual(expected, actual);

        }

    }
}
