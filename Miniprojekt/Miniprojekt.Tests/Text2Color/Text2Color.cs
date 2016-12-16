using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Miniprojekt.Tests.Text2Color
{
    using Miniprojekt.Models.Text2Color;

    [TestClass]
    public class Text2Color
    {
        [TestMethod]
        public void NewColorCanBeCreatedWithCustomValues()
        {
            // Arrange
            Color _color = new Color(name: "Green", hexvalue: "#00FF00");

            // Act


            // Assert
            var expected = "Green";
            Assert.AreEqual(expected, _color.Name);
        }

        [TestMethod]
        public void NeScoreCanBeCreatedWithCustomValues()
        {
            // Arrange
            Highscore _score = new Highscore(username: "Tropetre", points: 1337, time: DateTime.Now);

            // Act


            // Assert
            var expected = "Tropetre";
            Assert.AreEqual(expected, _score.Username);
        }
    }
}
