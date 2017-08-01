# Configuration.DockerSecrets

This project is be able to pull docker secrets into a DotNetCore configuration. Originally, I tried writing this from scratch and then came across Microsoft's [implementation](https://github.com/aspnet/Configuration) on GitHub. It is slated to be released with dotnetcore 2.0. Regardless of Microsoft's final implementation, our team needed to use this as soon as possible. 

The primary use case that inpired pulling this together is using a dockerized [NancyFx](http://nancyfx.org/) api on a Docker Swarm. As such, our example application is a NancyFx api.

## Installing Configuration.DockerSecrets

Using Nuget, install the [Configuration.DockerSecrets]() package. Your .csproj should include the following:

```xml
<ItemGroup Condition=" '$(TargetFramework)' == 'netcoreapp1.1' ">
    <PackageReference Include="Configuration.DockerSecrets" Version="1.0.0"/>
</ItemGroup>
```

## Usage

Pull in the docker secrets into your config.

```cs
    var config = new ConfigurationBuilder()
                    .AddDockerSecrets()
                    .Build();
```

Access your secrets where you need them using:

```cs
    var secret = config["secret-name"];
```

## Maintenance and Contributions

Contributions are always welcome. When dotnetcore is released, this package will not longer be maintained.

## License and Acknowledgements 

Most of this code is directly taken from Microsoft's ASP.NET [Configuration](https://github.com/aspnet/Configuration) repo. As a result, this repo is under the [Apache License, Version 2.0](LICENSE.txt).
