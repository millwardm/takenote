# install docker cli
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS base
RUN apt-get update
RUN apt-get install -y apt-transport-https ca-certificates curl gnupg-agent software-properties-common
RUN curl -fsSL https://download.docker.com/linux/debian/gpg | apt-key add -
RUN add-apt-repository "deb [arch=amd64] https://download.docker.com/linux/debian $(lsb_release -cs) stable"
RUN apt-get update
RUN apt-get -y install docker-ce

FROM base as build
WORKDIR /src
COPY src/ .
RUN dotnet restore "Services/Note/Note.FunctionalTests/Note.FunctionalTests.csproj"
WORKDIR /src/Services/Note/Note.FunctionalTests
RUN ["chmod", "+x", "./entrypoint.sh"]
RUN [ "chmod", "+x", "./perform_test.sh"]
CMD /bin/bash ./entrypoint.sh