FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["WebApi.RestApi/WebApi.RestApi.csproj", "WebApi.RestApi/"]
COPY ["WebApi.Application/WebApi.Application.csproj", "WebApi.Application/"]
COPY ["WebApi.Domain.Core/WebApi.Domain.Core.csproj", "WebApi.Domain.Core/"]
COPY ["WebApi.Domain/WebApi.Domain.csproj", "WebApi.Domain/"]
COPY ["WebApi.Infrastructure/WebApi.Infrastructure.csproj", "WebApi.Infrastructure/"]
COPY ["WebApi.Domain.Services/WebApi.Domain.Services.csproj", "WebApi.Domain.Services/"]
RUN dotnet restore "./WebApi.RestApi/./WebApi.RestApi.csproj"
COPY . .
WORKDIR "/src/WebApi.RestApi"
RUN dotnet build "./WebApi.RestApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./WebApi.RestApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApi.RestApi.dll"]