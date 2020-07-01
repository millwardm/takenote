USE master;

GO

DROP TABLE dbo.note;

GO

CREATE TABLE note.entry (
    ID int IDENTITY(1,1) PRIMARY KEY,
    NOTEBOOK_ID int,
    CONTENT varchar(max),
    CONSTRAINT FK_entry_notebook FOREIGN KEY (NOTEBOOK_ID) REFERENCES note.notebook(ID)
)

GO

