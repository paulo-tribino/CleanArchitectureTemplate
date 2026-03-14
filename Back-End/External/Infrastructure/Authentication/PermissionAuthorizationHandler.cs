using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;

namespace Infrastructure.Authentication;

public sealed class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
{
    protected override async Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        PermissionRequirement requirement)
    {
        var userId = context.User.Claims.FirstOrDefault(c =>
            c.Type.Equals(JwtRegisteredClaimNames.Sub))?.Value;

        if (!Guid.TryParse(userId, out var parsedUserId))
        {
            return;
        }

        context.Succeed(requirement);

        return;

        // TODO set permissions on user claims

        var permission = context.User.Claims.FirstOrDefault(c =>
            c.Value.Equals(requirement.Permission));

        if (permission is not null)
        {
            context.Succeed(requirement);
        }
    }
}
