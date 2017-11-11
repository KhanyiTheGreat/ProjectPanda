using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.OAuth;
using Owin;
using ProjectPanda.MobileAppService.Providers;
using ProjectPanda.MobileAppService.Models;

namespace ProjectPanda.MobileAppService
{
    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public static string PublicClientId { get; private set; }

        // For more information on configuring authentication, please visit https://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context and user manager to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseCookieAuthentication(new CookieAuthenticationOptions());
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Configure the application for OAuth based flow
            PublicClientId = "self";
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/Token"),
                Provider = new ApplicationOAuthProvider(PublicClientId),
                AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
                // In production mode set AllowInsecureHttp = false
                AllowInsecureHttp = true
            };

            // Enable the application to use bearer tokens to authenticate users
            app.UseOAuthBearerTokens(OAuthOptions);

            // Uncomment the following lines to enable logging in with third party login providers
            app.UseMicrosoftAccountAuthentication(
             clientId: "ddf910c8-6f98-4586-b26e-7b2e06f612a1",
               clientSecret: "rCfx4GPgh3EsUm0xaToJS4x");

            //app.UseTwitterAuthentication(
            //    consumerKey: "",
            //    consumerSecret: "");

                app.UseFacebookAuthentication(
                appId: "136133043698809",
                appSecret: "394e6027026c9b9f9a388c37e6d45e8f");

            app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            {
               ClientId = "655782672996-f7n91tloeocgksh8dogfuijhpfcre2m1.apps.googleusercontent.com",
                ClientSecret = "655782672996-f7n91tloeocgksh8dogfuijhpfcre2m1.apps.googleusercontent.com"
           });
        }
    }
}
