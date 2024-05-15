FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HomeWork6.1.csproj", "./"]
RUN dotnet restore "HomeWork6.1.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "HomeWork6.1.csproj" -c Release -o /app/build

FROM base AS final
WORKDIR /app
COPY --from=build /app/build .
ENTRYPOINT ["dotnet", "HomeWork6.1.dll"]