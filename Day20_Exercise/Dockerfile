#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Day20_Exercise/Day20_Exercise.csproj", "Day20_Exercise/"]
RUN dotnet restore "Day20_Exercise/Day20_Exercise.csproj"
COPY . .
WORKDIR "/src/Day20_Exercise"
RUN dotnet build "Day20_Exercise.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Day20_Exercise.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Day20_Exercise.dll"]