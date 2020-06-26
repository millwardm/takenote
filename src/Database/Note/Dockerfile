FROM openjdk:8
COPY src/Database/Note/setup_database.sh setup_database.sh
COPY src/Database/Note/entrypoint.sh entrypoint.sh
COPY src/Database/Note/Scripts .
COPY src/Database/Note/Liquibase .
RUN ["chmod", "+x", "./entrypoint.sh"]
RUN ["chmod", "+x", "./setup_database.sh"]
CMD /bin/bash ./entrypoint.sh