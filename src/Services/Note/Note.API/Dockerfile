#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY src/Services/Note/Note.API/Note.API.csproj Services/Note/Note.API/
RUN dotnet restore "Services/Note/Note.API/Note.API.csproj"
COPY src/ .
WORKDIR "/src/Services/Note/Note.API"
RUN dotnet build "Note.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Note.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Note.API.dll"]
