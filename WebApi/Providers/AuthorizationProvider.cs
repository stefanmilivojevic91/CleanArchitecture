using AspNet.Security.OAuth.Validation;
using AspNet.Security.OpenIdConnect.Extensions;
using AspNet.Security.OpenIdConnect.Primitives;
using AspNet.Security.OpenIdConnect.Server;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApi.Providers
{
    public class AuthorizationProvider : OpenIdConnectServerProvider
    {
        public override Task ValidateTokenRequest(ValidateTokenRequestContext context)
        {
            context.Skip();
            return Task.FromResult(0);
        }

        public override Task HandleTokenRequest(HandleTokenRequestContext context)
        {
            var identity = new ClaimsIdentity();

            var subjectClaim = new Claim(OpenIdConnectConstants.Claims.Subject, "Stefca");

            identity.AddClaim(subjectClaim);

            var ticket = new AuthenticationTicket(
                new ClaimsPrincipal(identity),
                new AuthenticationProperties(),
                OAuthValidationDefaults.AuthenticationScheme);

            ticket.SetScopes(OpenIdConnectConstants.Scopes.OpenId, 
                             OpenIdConnectConstants.Scopes.Email,
                             OpenIdConnectConstants.Scopes.Profile);

            context.Validate(ticket);
            return Task.FromResult(0);
        }
    }
}
