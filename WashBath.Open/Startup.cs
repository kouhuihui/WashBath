using AutoMapper;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Web.Http;
using WashBath.Core.Models;
using WashBath.Open.Models.User;
using WashBath.Open.Providers;

[assembly: OwinStartup(typeof(WashBath.Open.Startup))]

namespace WashBath.Open
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            ConfigureOAuth(app);
            ConfigureAutoMapper();

            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
        void ConfigureAutoMapper()
        {
            Mapper.Initialize(cfg =>
            {
                //cfg.CreateMap<SaleUser, UserListItemViewModel>().ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Role == null ? "" : src.Role.Name));
            });
        }
    }
}
