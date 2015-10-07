using Xunit;

namespace AzureStorageIntegrationTests.Tests
{
    [CollectionDefinition("AzureStorageIntegrationTests")]
    public class AzureStorageEmulatorCollection : ICollectionFixture<AzureStorageEmulatorFixture>
    {
    }
}
