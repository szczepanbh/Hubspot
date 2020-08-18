﻿using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace SoftwareHut.HubspotService.Test.IntegrationTests.HealthTests
{
    public class BootstrappedTestFixture : WebApplicationFactory<Startup>, IAsyncLifetime
    {
        public HttpClient TestClient { get; }

        public BootstrappedTestFixture()
        {
            TestClient = CreateClient();
        }

        public Task InitializeAsync() => Task.CompletedTask;
        public Task DisposeAsync() => Task.CompletedTask;
    }
}