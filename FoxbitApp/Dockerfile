#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FoxbitApp/FoxbitApp.csproj", "FoxbitApp/"]
COPY ["Foxbit.Domain/Foxbit.Domain.csproj", "Foxbit.Domain/"]
RUN dotnet restore "FoxbitApp/FoxbitApp.csproj"
COPY . .
WORKDIR "/src/FoxbitApp"
RUN dotnet build "FoxbitApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FoxbitApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FoxbitApp.dll"]