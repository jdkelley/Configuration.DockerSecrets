using Microsoft.Extensions.Configuration;
using Configuration.DockerSecrets;
using Nancy;

namespace Configuration.DockerSecrets
{
    public class NancyCoreBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            var config = new ConfigurationBuilder()
                .AddDockerSecrets()
                .Build();

            // Dependency Injection
            container.Register<IConfiguration>(config);
        }
    }
}
