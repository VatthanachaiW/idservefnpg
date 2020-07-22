using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;


namespace Payroll.Identities
{
    public static class Config
    {
        public static List<TestUser> GetUsers() =>
            new List<TestUser>
            {
                new TestUser
                {
                    IsActive = true,
                    Password = "P@ssword!",
                    Username = "test"
                }
            };

        public static IEnumerable<Client> GetClients() =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = {"api1"}
                }
            };

        public static IEnumerable<IdentityResource> GetIdentityResources() =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiResource> GetApiResources() =>
            new List<ApiResource>
            {
                new ApiResource("api1", "My API")
            };
    }
}