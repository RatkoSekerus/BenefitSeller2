# Stage 1: Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

# restore
COPY ["BenefitSeller.API.csproj", "BenefitSeller.API/"]
RUN dotnet restore 'BenefitSeller.API/BenefitSeller.API.csproj'

# build
COPY . ./BenefitSeller.API/
WORKDIR /src/BenefitSeller.API
RUN dotnet build 'BenefitSeller.API.csproj' -c Release -o /app/build

# Stage 2: Publish Stage
FROM build AS publish
RUN dotnet publish 'BenefitSeller.API.csproj' -c Release -o /app/publish

# Stage 3: Run Stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
ENV ASPNETCORE_HTTP_PORTS=5001
EXPOSE 5001
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "BenefitSeller.API.dll"]