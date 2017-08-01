FROM microsoft/dotnet:1.1.1-runtime
WORKDIR /app
COPY publish .
EXPOSE 8000
ENTRYPOINT ["dotnet", "Configuration.DockerSecrets.Example.dll"]