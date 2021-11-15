// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;
using IdentityServer4;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("resource_catalog") { Scopes = { "catalog_fullpermission" } },
            new ApiResource("resource_basket") { Scopes = { "basket_fullpermission" } },
            new ApiResource("resource_discount") { Scopes = { "discount_fullpermission" } },
            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                
                   };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
               new ApiScope("catalog_fullpermission"),
               new ApiScope("basket_fullpermission"),
               new ApiScope("discount_fullpermission"),
               new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientName = "AspNet Core MVC",
                 ClientId  = "WebMvcClient",
                 ClientSecrets =  {new Secret("secret".Sha256())},
                 AllowedGrantTypes = GrantTypes.ClientCredentials,
                 AllowedScopes = { "catalog_fullpermission", "basket_fullpermission", "discount_fullpermission", IdentityServerConstants.LocalApi.ScopeName }

                }

            };
    }
}