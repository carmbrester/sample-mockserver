#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Charm.Forum.Web/Charm.Forum.Web.csproj", "Charm.Forum.Web/"]
RUN dotnet restore "Charm.Forum.Web/Charm.Forum.Web.csproj"
COPY . .
WORKDIR "/src/Charm.Forum.Web"
RUN dotnet build "Charm.Forum.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Charm.Forum.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Charm.Forum.Web.dll"]