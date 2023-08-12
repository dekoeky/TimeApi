#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TimeApi/TimeApi.csproj", "TimeApi/"]
RUN dotnet restore "TimeApi/TimeApi.csproj"
COPY . .
WORKDIR "/src/TimeApi"
RUN dotnet build "TimeApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TimeApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
LABEL org.opencontainers.image.description="A simple rest api that returns time information"
LABEL test.label.value="Test 004"
LABEL description="Some Description 🐱‍💻"
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TimeApi.dll"]