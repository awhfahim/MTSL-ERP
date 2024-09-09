FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/MTSL_ERP.API/MTSL_ERP.API.csproj", "src/MTSL_ERP.API/"]
COPY ["PrintingFactoryManagement.HttpApi/PrintingFactoryManagement.HttpApi.csproj", "PrintingFactoryManagement.HttpApi/"]
COPY ["SewingMachineManagement.HttpApi/SewingMachineManagement.HttpApi.csproj", "SewingMachineManagement.HttpApi/"]
RUN dotnet restore "src/MTSL_ERP.API/MTSL_ERP.API.csproj"
COPY . .
WORKDIR "/src/src/MTSL_ERP.API"
RUN dotnet build "MTSL_ERP.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "MTSL_ERP.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MTSL_ERP.API.dll"]
