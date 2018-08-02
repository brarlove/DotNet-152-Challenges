using System;
using Challenge_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_2_Test
{
    [TestClass]
    public class UnitTest2
    {
        Challenge_2.Claim_Repo newClaim_Repo;
        [TestInitialize]
        public void Arrange()
        {
            newClaim_Repo = new Challenge_2.Claim_Repo();
        }
        [TestMethod]
        public void Claim_Repo_addClaimToList_ShouldIncreaseCountByOne()
        {
            Claim Car = new Claim(1, "Car", "Accident at 465", 2000.00, DateTime.Parse("07/25/18"), DateTime.Parse("07/31/18"), true);
            newClaim_Repo.addClaimToList(Car);

            var actual = newClaim_Repo.showRepoList().Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Claim_Repo_removeClaimFromList_ShouldDecreaseCountByOne()
        {

            Claim Car = new Claim(1, "Car", "Accident at 465", 2000.00, DateTime.Parse("07/25/18"), DateTime.Parse("07/31/18"), true);
            Claim House = new Claim(2, "House", "Fire", 20000.00, DateTime.Parse("07/26/18"), DateTime.Parse("07/31/18"), true);
            Claim Theft = new Claim(3, "Theft", "Stolen Purse", 200.00, DateTime.Parse("06/25/18"), DateTime.Parse("07/31/18"), false);
            newClaim_Repo.addClaimToList(Car);
            newClaim_Repo.addClaimToList(House);
            newClaim_Repo.addClaimToList(Theft);

            newClaim_Repo.removeClaimFromList(House);

            var actual = newClaim_Repo.showRepoList().Count;
            var expected = 2;

            Assert.AreEqual(actual, expected);
        }

    }
}
