#!/bin/bash

i=0
while [ ! "$(docker ps -aq -f status=exited -f name=src_liquibase_1)" ]
do
    if (( $i > 10 )); then
        echo "timeout waiting for liquibase to finish"
        exit 1
    fi
    i=$[$i+1]
    sleep 5
done

echo "liquibase exited, run tests"
dotnet test