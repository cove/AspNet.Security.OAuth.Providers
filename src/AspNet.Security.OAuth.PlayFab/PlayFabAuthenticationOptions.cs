/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Identity;

namespace AspNet.Security.OAuth.PlayFab
{
    /// <summary>
    /// Defines a set of options used by <see cref="PlayFabAuthenticationHandler"/>.
    /// </summary>
    public class PlayFabAuthenticationOptions : OAuthOptions
    {
        public PlayFabAuthenticationOptions()
        {
            ClaimsIssuer = PlayFabAuthenticationDefaults.Issuer;
            CallbackPath = PlayFabAuthenticationDefaults.CallbackPath;
            AuthorizationEndpoint = PlayFabAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = PlayFabAuthenticationDefaults.TokenEndpoint;
            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
            ClaimActions.MapJsonKey(ClaimTypes.Role, "type");
        }
    }
}
