using Nancy;
using Microsoft.Extensions.Configuration;
using Nancy.Configuration;
using System;

namespace Configuration.DockerSecrets.Example
{
    public class HomeModule : NancyModule
    {
        public HomeModule(IConfiguration config)
        {
            Get("/", _ => "up");

            Get("/secrets/{secretname}", args =>
            {
                string secret = config[$"{args.secretname}"];
                return new { secretContents = secret };
            });
        }
    }
}
