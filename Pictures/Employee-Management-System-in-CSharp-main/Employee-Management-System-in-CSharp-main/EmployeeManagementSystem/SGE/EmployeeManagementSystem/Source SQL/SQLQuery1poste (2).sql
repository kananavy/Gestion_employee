CREATE TABLE [dbo].[poste] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [poste_id]    VARCHAR (MAX) NULL,
    [poste_name]  VARCHAR (MAX) NULL,
    [poste_tache] VARCHAR (MAX) NULL,
    [insert_date]  DATE          NULL,
    [update_date]  DATE          NULL,
    [delete_date]  DATE          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

