#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DLPR.LicensePlateData.Uploader/DLPR.LicensePlateData.Uploader.csproj", "DLPR.LicensePlateData.Uploader/"]
COPY ["DLPR.LicensePlateData.Infrastructure/DLPR.LicensePlateData.Infrastructure.csproj", "DLPR.LicensePlateData.Infrastructure/"]
COPY ["DLPR.LicensePlateData.Application/DLPR.LicensePlateData.Application.csproj", "DLPR.LicensePlateData.Application/"]
COPY ["DLPR.LicensePlateData.Domain/DLPR.LicensePlateData.Domain.csproj", "DLPR.LicensePlateData.Domain/"]
RUN dotnet restore "DLPR.LicensePlateData.Uploader/DLPR.LicensePlateData.Uploader.csproj"
COPY . .
WORKDIR "/src/DLPR.LicensePlateData.Uploader"
RUN dotnet build "DLPR.LicensePlateData.Uploader.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DLPR.LicensePlateData.Uploader.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DLPR.LicensePlateData.Uploader.dll"]