FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["WebApplication16.csproj", "WebApplication16Project/"]
RUN dotnet restore "WebApplication16Project/WebApplication16.csproj"
COPY . .
RUN dotnet build "WebApplication16.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplication16.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication16.dll"]