#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

# ESTÁGIO 1
#FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443

# ESTÁGIO 2
#FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
#FROM microsoft/dotnet:2.2-aspnetcore:runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR ./source/repos/Controle-Cursos1/Controle-Cursos1
COPY ["./Controle-Cursos1.csproj", "Controle-Cursos1/"]
RUN dotnet restore "Controle-Cursos1/Controle-Cursos1.csproj"
COPY . ./
WORKDIR "./source/repos/Controle-Cursos1/Controle-Cursos1"
RUN dotnet build "Controle-Cursos1.csproj" -c Release -o /app/build

# ESTÁGIO 3
FROM build AS publish
RUN dotnet publish "Controle-Cursos1.csproj" -c Release -o /app/publish

# ESTÁGIO 4
FROM base AS final

LABEL version="1.0" maintainer="Renato Liberato"

WORKDIR /app
COPY ./source/repos/Controle-Cursos1/Controle-Cursos1/dist .
#COPY --from=publish /app/publish .
#COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "controle-cursos1.dll"]
#CMD ASPNETCORE_URLS="http://*:$PORT" dotnet controle-cursos1.dll