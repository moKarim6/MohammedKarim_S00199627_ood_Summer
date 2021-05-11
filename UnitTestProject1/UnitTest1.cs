using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MohammedKarim_S00199627;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrice()
        {
            // ARRANGE
            Game game1 = new Game("Mario", 85, "Arcade", "Nintendo", 50m);
            decimal finalprice = 0m;

            // ACT
            game1.DecreasePrice(50m);

            // ASSERT
            Assert.AreEqual(finalprice, game1.Price);
        }
    }
}
