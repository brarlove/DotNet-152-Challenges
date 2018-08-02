using System;
using Challenge1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_1_Test
{
    [TestClass]
    public class UnitTest1
    {
        Challenge1.MenuRepo newMenuRepo;
        [TestInitialize]
        public void Arrange()
        {
            newMenuRepo = new Challenge1.MenuRepo();
        }

        [TestMethod]
        public void MenuRepo_addMenuToList_shouldIncreaseCountByOne()
        {
            MenuItem burger = new MenuItem("burger", "delicious burger", "cheese,pickles,cucumbers", 5.99, 1);
            newMenuRepo.addMenuToList(burger);

            var actual = newMenuRepo.showMenuList().Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepo_removeMenuFromList_shouldDecreaseCountByOne()
        {
            MenuItem burger = new MenuItem("burger", "delicious burger", "cheese,pickles,cucumbers", 5.99, 1);
            MenuItem pizza = new MenuItem("pizza", "delicious pizza", "cheese,onions,olives", 9.99, 2);
            MenuItem salad = new MenuItem("salad", "delicious salad", "cheese,lettuce,onions", 4.99, 3);

            newMenuRepo.addMenuToList(pizza);
            newMenuRepo.addMenuToList(burger);
            newMenuRepo.addMenuToList(salad);

            newMenuRepo.removeMenuFromList(pizza);

            var actual = newMenuRepo.showMenuList().Count;
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}
