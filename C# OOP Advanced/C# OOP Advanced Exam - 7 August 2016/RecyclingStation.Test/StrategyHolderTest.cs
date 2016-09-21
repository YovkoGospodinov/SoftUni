namespace RecyclingStation.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RecyclingStation.Models.DisposalStrategies;
    using RecyclingStation.Models.Waste;
    using RecyclingStation.WasteDisposal;
    using RecyclingStation.WasteDisposal.Attributes;

    [TestClass]
    public class StrategyHolderTest
    {
        [TestMethod]
        public void Constructor_ShouldInitializeCorrectlyTheObject()
        {
            // Arrange
            var strategyHolder = new StrategyHolder();

            // Act and Assert
            Assert.IsNotNull(strategyHolder);
        }

        [TestMethod]
        public void AddStrategy_ShouldReturnTrue_WhenRecieveValidParameters()
        {
            // Arrange
            var strategy = new BurnableDisposalStrategy();
            var type = new DisposableAttribute();
            var holder = new StrategyHolder();

            // Act and Assert
            Assert.IsTrue(holder.AddStrategy(type, strategy));
        }

        [TestMethod]
        public void RemoveStrategy_ShouldReturnTrue_WhenRecieveValidParameters()
        {
            // Arrange
            var strategy = new BurnableDisposalStrategy();
            var type = new DisposableAttribute();
            var holder = new StrategyHolder();

            // Act and Assert
            Assert.IsTrue(holder.RemoveStrategy(type));
        }
    }
}