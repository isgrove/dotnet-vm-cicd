FROM mcr.microsoft.com/dotnet/sdk:7.0

RUN apt-get update && apt-get install -y
RUN apt install openssh-client -y