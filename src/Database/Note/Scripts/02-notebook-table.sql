USE master;

GO

CREATE SCHEMA note;

GO

CREATE TABLE note.notebook (
    ID int IDENTITY(1,1) PRIMARY KEY,
    NAME varchar(max) NOT NULL
)

GO