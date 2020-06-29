kubectl create secret generic note-db-cred --from-literal="NOTEDB_USERNAME=<USERNAME_HERE>" --from-literal="NOTEDB_PASSWORD=<PASSWORD_HERE>"
kubectl create secret generic note-db-cred --from-literal="NOTEDB_USERNAME=sa" --from-literal="NOTEDB_PASSWORD=secretPASSCODE()"
