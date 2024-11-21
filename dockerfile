# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar apenas o arquivo .csproj para restaurar dependências
COPY ./Proj/VendasPOO.csproj ./Proj/

# Restaurar dependências
RUN dotnet restore ./Proj/VendasPOO.csproj

# Copiar todos os arquivos do projeto
COPY ./Proj ./Proj

# Fazer o build do projeto
RUN dotnet publish ./Proj/VendasPOO.csproj -c Release -o /app/publish

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/publish .

# Executa o programa
ENTRYPOINT ["dotnet", "VendasPOO.dll"]