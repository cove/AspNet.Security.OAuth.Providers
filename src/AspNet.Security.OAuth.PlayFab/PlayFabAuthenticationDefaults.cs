/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace AspNet.Security.OAuth.PlayFab
{
    /// <summary>
    /// Default values used by the PlayFab authentication middleware.
    /// </summary>
    public static class PlayFabAuthenticationDefaults
    {
        /// <summary>
        /// Default value for <see cref="AuthenticationScheme.Name"/>.
        /// </summary>
        public const string AuthenticationScheme = "PlayFab";

        /// <summary>
        /// Default value for <see cref="AuthenticationScheme.DisplayName"/>.
        /// </summary>
        public const string DisplayName = "PlayFab";

        /// <summary>
        /// Default value for <see cref="AuthenticationSchemeOptions.ClaimsIssuer"/>.
        /// </summary>
        public const string Issuer = "PlayFab";

        /// <summary>
        /// Default value for <see cref="RemoteAuthenticationOptions.CallbackPath"/>, unimplemented in PlayFab.
        /// </summary>
        public const string CallbackPath = "/null";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.AuthorizationEndpoint"/>.
        /// </summary>
        public const string AuthorizationEndpoint = "https://{0}.playfabapi.com/Authentication/ValidateEntityToken";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.TokenEndpoint"/>
        /// </summary>
        public const string TokenEndpoint = "https://{0}.playfabapi.com/Client/LoginWithCustomID";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.UserInformationEndpoint"/>.
        /// </summary>
        public const string UserInformationEndpoint = "https://{0}.playfabapi.com/Client/GetAccountInfo";
    }
}
