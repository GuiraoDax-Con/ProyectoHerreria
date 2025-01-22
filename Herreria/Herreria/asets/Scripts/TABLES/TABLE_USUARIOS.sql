--USUARIO
CREATE TABLE [dbo].[USUARIO] (
    [id]       INT            IDENTITY (1, 1) NOT NULL,
    [nombre]   NVARCHAR (100) NOT NULL,
    [password] NVARCHAR (255) NOT NULL,
    [rol]      NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [CHK_Rol] CHECK ([rol]='administrador' OR [rol]='usuario')
);
Go