# Use the official ASP.NET Core runtime as the base image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 5148
EXPOSE 7130

# Use the .NET Core SDK to build the application
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FranRGIS.csproj", "./"]
RUN dotnet restore "FranRGIS.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "FranRGIS.csproj" -c Release -o /app/build


# Publish the application
FROM build AS publish
RUN dotnet publish "FranRGIS.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final image with the published app
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FranRGIS.dll"]
