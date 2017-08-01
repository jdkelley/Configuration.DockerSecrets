using Nancy.Owin;
using Microsoft.AspNetCore.Builder;

namespace Configuration.DockerSecrets.Example
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy(opt => opt.Bootstrapper = new NancyCoreBootstrapper()));
        }
    }
}