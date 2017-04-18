using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityServer4.Quickstart.UI
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser{SubjectId = "818727", Username = "corey", Password = "corey", 
                Claims = 
                {
                    new Claim(JwtClaimTypes.Name, "corey Floyd"),
                    new Claim(JwtClaimTypes.GivenName, "corey"),
                    new Claim(JwtClaimTypes.FamilyName, "Floyd"),
                    new Claim(JwtClaimTypes.Email, "coreyFloyd@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://corey.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'Ironforge Rd', 'locality': 'Pensacola', 'postal_code': 32533, 'country': 'America' }", IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser{SubjectId = "88421113", Username = "julie", Password = "julie", 
                Claims = 
                {
                    new Claim(JwtClaimTypes.Name, "Bob Floyd"),
                    new Claim(JwtClaimTypes.GivenName, "Julie"),
                    new Claim(JwtClaimTypes.FamilyName, "Floyd"),
                    new Claim(JwtClaimTypes.Email, "BobFloyd@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://Julie.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'Ironforge Rd', 'locality': 'Pensacola', 'postal_code': 32533, 'country': 'America' }", IdentityServerConstants.ClaimValueTypes.Json),
                    new Claim("location", "somewhere"),
                }
            },
        };
    }
}