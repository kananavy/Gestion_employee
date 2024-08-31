CREATE TABLE [dbo].[departement] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [depart_id]    VARCHAR (MAX) NULL,
    [depart_name]      VARCHAR (MAX) NULL,
    [tache_depart]         VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

