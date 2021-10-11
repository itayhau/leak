FROM mcr.microsoft.com/dotnet/sdk:3.1

COPY bin/Release/netcoreapp3.1/publish/ App/
WORKDIR /App

ENV DOTNET_DbgEnableMiniDump 1

ENTRYPOINT ["dotnet", "Leaker.dll"]