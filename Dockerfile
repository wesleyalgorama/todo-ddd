FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY *.sln ./
COPY Todo.Api/*.csproj ./Todo.Api/
COPY Todo.Application/*.csproj ./Todo.Application/
COPY Todo.Domain/*.csproj ./Todo.Domain/
COPY Todo.Infrastructure/*.csproj ./Todo.Infrastructure/
COPY Todo.Tests/*.csproj ./Todo.Tests/

RUN dotnet restore Todo.Api/Todo.Api.csproj

COPY . ./
WORKDIR /src/Todo.Api
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "Todo.Api.dll"]
