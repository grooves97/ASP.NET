FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["WebApplication21/WebApplication21.csproj", "WebApplication21/"]
RUN dotnet restore "WebApplication21/WebApplication21.csproj"
COPY . .
WORKDIR "/src/WebApplication21"
RUN dotnet build "WebApplication21.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplication21.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication21.dll"]