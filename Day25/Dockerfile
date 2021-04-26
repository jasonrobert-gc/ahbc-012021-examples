#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Day25/Day25.csproj", "Day25/"]
RUN dotnet restore "Day25/Day25.csproj"
COPY . .
WORKDIR "/src/Day25"
RUN dotnet build "Day25.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Day25.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Day25.dll"]