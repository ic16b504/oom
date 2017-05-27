
using NUnit.Framework;

namespace Task4
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CreateMagicCard()
        {
            var m = new MagicCard("Garruk Wildspeaker", "Lorwyn", 8.5);
            Assert.IsTrue(m.Name == "Garruk Wildspeaker");
            Assert.IsTrue(m.Edition == "Lorwyn");
            Assert.IsTrue(m.Price == 8.5);
        }

        [Test]
        public void EmptyName()
        {
            Assert.Catch(() =>
            {
                var m = new MagicCard(null, "Lorwyn", 8.5);
            });
        }

        [Test]
        public void EmptyEdition()
        {
            Assert.Catch(() =>
            {
                var m = new MagicCard("Garruk Wildspeaker", "", 8.5);
            });
        }

        [Test]
        public void NegativePrice()
        {
            Assert.Catch(() =>
            {
                var m = new MagicCard("Garruk Wildspeaker", "Lorwyn", -8.5);
            });
        }

        [Test]
        public void UpdateMagicCardPrice()
        {
            var m = new MagicCard("Garruk Wildspeaker", "Lorwyn", 8.5);
            m.UpdatePrice(6.5);
            Assert.IsTrue(m.Price == 6.5);
        }
    }
}
