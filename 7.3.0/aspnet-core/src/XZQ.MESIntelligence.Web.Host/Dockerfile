#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/XZQ.MESIntelligence.Web.Host/XZQ.MESIntelligence.Web.Host.csproj", "src/XZQ.MESIntelligence.Web.Host/"]
COPY ["src/XZQ.MESIntelligence.Web.Core/XZQ.MESIntelligence.Web.Core.csproj", "src/XZQ.MESIntelligence.Web.Core/"]
COPY ["src/XZQ.MESIntelligence.Application/XZQ.MESIntelligence.Application.csproj", "src/XZQ.MESIntelligence.Application/"]
COPY ["src/XZQ.MESIntelligence.Core/XZQ.MESIntelligence.Core.csproj", "src/XZQ.MESIntelligence.Core/"]
COPY ["src/XZQ.MESIntelligence.EntityFrameworkCore/XZQ.MESIntelligence.EntityFrameworkCore.csproj", "src/XZQ.MESIntelligence.EntityFrameworkCore/"]
RUN dotnet restore "src/XZQ.MESIntelligence.Web.Host/XZQ.MESIntelligence.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/XZQ.MESIntelligence.Web.Host"
RUN dotnet build "XZQ.MESIntelligence.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "XZQ.MESIntelligence.Web.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "XZQ.MESIntelligence.Web.Host.dll"]