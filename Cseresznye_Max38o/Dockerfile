#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Cseresznye_Max38o/Cseresznye_Max38o.csproj", "Cseresznye_Max38o/"]
RUN dotnet restore "Cseresznye_Max38o/Cseresznye_Max38o.csproj"
COPY . .
WORKDIR "/src/Cseresznye_Max38o"
RUN dotnet build "Cseresznye_Max38o.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cseresznye_Max38o.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cseresznye_Max38o.dll"]