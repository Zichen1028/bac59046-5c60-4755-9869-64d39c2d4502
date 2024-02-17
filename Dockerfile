# Container image that runs your code
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Copy everything
COPY . ./

# Restore as distinct layers
RUN dotnet restore

# Build the project
RUN dotnet build

RUN dotnet run --project ./bac59046-5c60-4755-9869-64d39c2d4502
