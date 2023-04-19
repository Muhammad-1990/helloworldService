FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY helloworldService.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /inetpub/wwwroot

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /inetpub/wwwroot
COPY --from=build /inetpub/wwwroot .
ENTRYPOINT ["dotnet", "helloworldService.dll"]
EXPOSE 80