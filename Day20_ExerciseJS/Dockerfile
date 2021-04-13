#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Day20_ExerciseJS/Day20_ExerciseJS.csproj", "Day20_ExerciseJS/"]
RUN dotnet restore "Day20_ExerciseJS/Day20_ExerciseJS.csproj"
COPY . .
WORKDIR "/src/Day20_ExerciseJS"
RUN dotnet build "Day20_ExerciseJS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Day20_ExerciseJS.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Day20_ExerciseJS.dll"]