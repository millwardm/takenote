#!/usr/bin/env bash
# Wait for database to startup 
# TODO: change this to use a health check rather than sleep
sleep 20

# Generate default tables
./liquibase --url ${NOTEDB_JDBC_URL} --username ${NOTEDB_USERNAME} --password ${NOTEDB_PASSWORD} --changeLogFile ./changelog-init.xml --driver=com.microsoft.sqlserver.jdbc.SQLServerDriver --classpath=lib/mssql-jdbc-8.2.2.jre8.jar update
if [ $? != 0 ] 
then
    exit 1
fi
echo "Inital liquibase set up done"

./liquibase --url ${NOTEDB_JDBC_URL} --username ${NOTEDB_USERNAME} --password ${NOTEDB_PASSWORD} --changeLogFile ./changelog-main.xml --driver=com.microsoft.sqlserver.jdbc.SQLServerDriver --classpath=lib/mssql-jdbc-8.2.2.jre8.jar update
if [ $? != 0 ] 
then
    exit 1
fi
echo "Custom change set done"

exit 0
