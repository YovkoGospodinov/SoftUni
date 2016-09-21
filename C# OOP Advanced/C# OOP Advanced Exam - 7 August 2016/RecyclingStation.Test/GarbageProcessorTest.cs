namespace RecyclingStation.Test
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RecyclingStation.Models.DisposalStrategies;
    using RecyclingStation.Models.Waste;
    using RecyclingStation.WasteDisposal.Attributes;
    using RecyclingStation.WasteDisposal.Interfaces;
    using RecyclingStation.WasteDisposal;
    using System;
    
    [TestClass]
    public class GarbageProcessorTest
    {
        [TestMethod]
        public void Constructor_ShouldInitializeObject_WhenValidItemIsPassed()
        {
            // Arrange
            var strategyHolder = new StrategyHolder();


            // Act
            var garbageProcessor = new GarbageProcessor(strategyHolder);

            // Assert
            Assert.AreEqual(strategyHolder, garbageProcessor.StrategyHolder);
        }


        //This test seems to be the same like the previous one, but in case of any changes in the logic it has to exist.
        [TestMethod]
        public void PropertyStrategyHolder_ShouldGetCorrectly()
        {
            // Arrange
            var strategyHolder = new StrategyHolder();
            var garbageProcessor = new GarbageProcessor(strategyHolder);

            // Act
            var actualStrategyHolder = garbageProcessor.StrategyHolder;

            // Assert
            Assert.AreEqual(strategyHolder, actualStrategyHolder);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProcessWaste_ShouldThrowArgumentException()
        {
            // Arrange
            var garbage = new StorableWaste("glass", 10.5, 1.2);
            var strategyHolder = new StrategyHolder();
            var garbageProcessor = new GarbageProcessor(strategyHolder);

            // Act and Assert
            garbageProcessor.ProcessWaste(garbage);

        }

        [TestMethod]
        public void ProcessWaste_ShouldReturnValidCurrentStrategy()
        {
            // Arrange
            var garbage = new StorableWaste("glass", 10.5, 1.2);
            var strategyHolder = new StrategyHolder();
            var garbageProcessor = new GarbageProcessor(strategyHolder);

            Type type = garbage.GetType();
            DisposableAttribute disposalAttribute = (DisposableAttribute)type.GetCustomAttributes(true).FirstOrDefault(x => x.GetType() == typeof(DisposableAttribute));
            IGarbageDisposalStrategy currentStrategy = new BurnableDisposalStrategy();
            var expectedResult = currentStrategy.ProcessGarbage(garbage);

            // Act
            var actualResult = garbageProcessor.ProcessWaste(garbage);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
