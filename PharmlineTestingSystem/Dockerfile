#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["PharmlineTestingSystem/PharmlineTestingSystem.csproj", "PharmlineTestingSystem/"]
COPY ["PharmlineTestingSystem.Database/PharmlineTestingSystem.Database.csproj", "PharmlineTestingSystem.Database/"]
COPY ["PharmlineTestingSystem.Models/PharmlineTestingSystem.Models.csproj", "PharmlineTestingSystem.Models/"]
COPY ["PharmlineTestingSystem.Repository/PharmlineTestingSystem.Repository.csproj", "PharmlineTestingSystem.Repository/"]
COPY ["PharmlineTestingSystem.Shared/PharmlineTestingSystem.Shared.csproj", "PharmlineTestingSystem.Shared/"]
COPY ["PharmlineTestingSystem.Utils/PharmlineTestingSystem.Utils.csproj", "PharmlineTestingSystem.Utils/"]
RUN dotnet restore "./PharmlineTestingSystem/PharmlineTestingSystem.csproj"
COPY . .
WORKDIR "/src/PharmlineTestingSystem"
RUN dotnet build "./PharmlineTestingSystem.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./PharmlineTestingSystem.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PharmlineTestingSystem.dll"]