# Base image për runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Build image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Kopjo gjithë projektin dhe restore/build
COPY . .
RUN dotnet restore "./MyDotnetApp.csproj"
RUN dotnet build "./MyDotnetApp.csproj" -c Release -o /app/build

# Publish
FROM build AS publish
RUN dotnet publish "./MyDotnetApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "MyDotnetApp.dll"]
