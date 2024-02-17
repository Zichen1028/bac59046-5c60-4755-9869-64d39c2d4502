# Container image that runs your code
FROM alpine:3.10

# Copy everything
COPY . ./

# Restore as distinct layers
RUN dotnet restore

# Build the project
RUN dotnet build
