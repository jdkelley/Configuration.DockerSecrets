#! /bin/bash

# dotnet publish 

(
    dotnet restore
    dotnet build
    dotnet publish -c Release -o publish
)

# docker service 

(
    docker build -t config-test .
    echo "test-secret" | docker secret create my-secret -
    docker service create -p 8000:8000 --name configtest --secret my-secret config-test
)
