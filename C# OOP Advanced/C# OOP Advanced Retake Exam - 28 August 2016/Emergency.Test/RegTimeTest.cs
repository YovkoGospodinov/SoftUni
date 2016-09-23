namespace Emergency.Test
{
    using EmergencySystem.Utils;
    using NUnit.Framework;

    [TestFixture]
    public class RegTimeTest
    {
        [Test]
        public void RegistrationTimeConstructor_ShouldReturnValidTime()
        {
            // Arrange
            string expectedResult = "11:12 05/04/2000";

            // Act
            var registrationTime = new RegistrationTime("11:12 05/04/2000");
            string actualResult = registrationTime.ToString();

            // Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
