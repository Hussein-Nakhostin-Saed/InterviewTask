FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .
RUN dotnet restore "PharmacyApi/PharmacyApi.csproj"
RUN dotnet build "PharmacyApi/PharmacyApi.csproj" -c Release -o /app/build
RUN dotnet publish "PharmacyApi/PharmacyApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "PharmacyApi.dll"]
EXPOSE 80