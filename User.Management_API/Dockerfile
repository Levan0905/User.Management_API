#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["User.Management_API/User.Management_API.csproj", "User.Management_API/"]
RUN dotnet restore "User.Management_API/User.Management_API.csproj"
COPY . .
WORKDIR "/src/User.Management_API"
RUN dotnet build "User.Management_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "User.Management_API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "User.Management_API.dll"]