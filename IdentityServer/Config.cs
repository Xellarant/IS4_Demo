// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace IdentityServer
{
    public static class Config // everything commented out is now being pulled from db.
    {
        //public static IEnumerable<IdentityResource> GetIdentityResources()
        //{
        //    return new List<IdentityResource>
        //    {
        //        new IdentityResources.OpenId(),
        //        new IdentityResources.Profile(),
        //    };
        //}

        //public static IEnumerable<ApiResource> GetApis()
        //{
        //    return new List<ApiResource>
        //    {
        //        new ApiResource("api1", "My API")
        //    };
        //}

        //public static IEnumerable<Client> GetClients()
        //{
        //    return new List<Client>
        //    {
        //        new Client // Authorization Code example
        //        {
        //            ClientId = "client",

        //            // no interactive user, use the clientid/secret for authentication
        //            AllowedGrantTypes = GrantTypes.ClientCredentials,

        //            // secret for authentication
        //            ClientSecrets =
        //            {
        //                new Secret(new SHA256Managed().ComputeHash(Encoding.GetEncoding(1252).GetBytes("secret")).ToString())
        //            },

        //            // scopes that client has access to
        //            AllowedScopes = { "api1" }
        //        },

        //        new Client // Resource Owner example
        //        {
        //            ClientId = "ro.client",
        //            AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

        //            ClientSecrets =
        //            {
        //                new Secret(new SHA256Managed().ComputeHash(Encoding.GetEncoding(1252).GetBytes("secret")).ToString())
        //            },
        //            AllowedScopes = { "api1" }
        //        },

                //// OpenID Connect implicit flow client (MVC)
                //new Client
                //{
                //    ClientId = "mvc",
                //    ClientName = "MVC Client",
                //    AllowedGrantTypes = GrantTypes.Implicit,

                //    // where to redirect to after login
                //    RedirectUris = {"https://localhost:44319/signin-oidc"},

                //    //where to redirect to after logout
                //    PostLogoutRedirectUris = {"https://localhost:44319/signout-callback-oidc"},

                //    AllowedScopes = new List<string>
                //    {
                //        IdentityServerConstants.StandardScopes.OpenId,
                //        IdentityServerConstants.StandardScopes.Profile
                //    }
                //}

                // OpenID Connect hybrid flow client (MVC)
        //        new Client
        //        {
        //            ClientId = "mvc",
        //            ClientName = "MVC Client",
        //            AllowedGrantTypes = GrantTypes.Hybrid,

        //            ClientSecrets =
        //            {
        //                new Secret(new SHA256Managed().ComputeHash(Encoding.GetEncoding(1252).GetBytes("secret")).ToString())
        //            },

        //            RedirectUris           = { "https://localhost:44319/signin-oidc" },
        //            PostLogoutRedirectUris = { "https://localhost:44319/signout-callback-oidc" },

        //            AllowedScopes =
        //            {
        //                IdentityServerConstants.StandardScopes.OpenId,
        //                IdentityServerConstants.StandardScopes.Profile,
        //                "api1"
        //            },
        //            AllowOfflineAccess = true
        //        },

        //        // JavaScript Client
        //        new Client
        //        {
        //            ClientId = "js",
        //            ClientName = "JavaScript Client",
        //            AllowedGrantTypes = GrantTypes.Code,
        //            RequirePkce = true,
        //            RequireClientSecret = false,

        //            RedirectUris =           { "https://localhost:44375/callback.html" },
        //            PostLogoutRedirectUris = { "https://localhost:44375/index.html" },
        //            AllowedCorsOrigins =     { "https://localhost:44375" },

        //            AllowedScopes =
        //            {
        //                IdentityServerConstants.StandardScopes.OpenId,
        //                IdentityServerConstants.StandardScopes.Profile,
        //                "api1"
        //            }
        //        }
        //    };
        //}

        //public static List<TestUser> GetUsers()
        //{
        //    return new List<TestUser>
        //    {
        //        new TestUser
        //        {
        //            SubjectId = "1",
        //            Username = "alice",
        //            Password = "password",

        //            Claims = new []
        //            {
        //                new Claim("name", "Alice"),
        //                new Claim("website", "https://alice1.com")
        //            }
        //        },

        //        new TestUser
        //        {
        //            SubjectId = "2",
        //            Username = "bob",
        //            Password = "password",

        //            Claims = new []
        //            {
        //                new Claim("name", "Bob"),
        //                new Claim("website", "https://bob.com")
        //            }
        //        }
        //    };
        //}
    }
}