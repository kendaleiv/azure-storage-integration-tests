using RimDev.Automation.StorageEmulator;
using System;

namespace AzureStorageIntegrationTests.Tests
{
    public class AzureStorageEmulatorFixture : IDisposable
    {
        private readonly AzureStorageEmulatorAutomation _automation;

        public AzureStorageEmulatorFixture()
        {
            _automation = new AzureStorageEmulatorAutomation();

            Console.WriteLine("----- Invoking Automation Start -----");
            _automation.Start();
        }

        public void Dispose()
        {
            Console.WriteLine("----- Invoking Automation Dispose -----");
            _automation.Dispose();
        }
    }
}
