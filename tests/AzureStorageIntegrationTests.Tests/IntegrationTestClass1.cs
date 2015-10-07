using RimDev.Automation.StorageEmulator;
using Xunit;

namespace AzureStorageIntegrationTests.Tests
{
    [Collection("AzureStorageIntegrationTests")]
    public class IntegrationTestClass1
    {
        [Fact]
        public void VerifyEmulatorIsRunning()
        {
            Assert.True(AzureStorageEmulatorAutomation.IsEmulatorRunning());
        }
    }
}
