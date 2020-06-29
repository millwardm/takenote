#!/usr/bin/env bash
set -m
#./opt/mssql/bin/sqlservr & 
./setup_database.sh

if [ $? != 0 ] 
then
    exit 1
fi
exit 0

fg