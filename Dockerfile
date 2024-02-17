# Container image that runs your code
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Copy everything
COPY . ./

# Restore as distinct layers
RUN dotnet restore

# Build the project
RUN dotnet build
