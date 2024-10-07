# Вказуємо базовий образ
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Вказуємо образ для побудови
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ChatApp.csproj", "./"]
RUN dotnet restore "./ChatApp.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "ChatApp.csproj" -c Release -o /app/build

# Публікація додатку
FROM build AS publish
RUN dotnet publish "ChatApp.csproj" -c Release -o /app/publish

# Завершальний етап
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ChatApp.dll"]

