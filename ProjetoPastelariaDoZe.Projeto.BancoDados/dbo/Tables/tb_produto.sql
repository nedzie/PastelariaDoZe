CREATE TABLE [dbo].[tb_produto] (
    [id_produto]     INT             IDENTITY (1, 1) NOT NULL,
    [nome]           VARCHAR (120)   NOT NULL,
    [valor_unitario] DECIMAL (11, 2) NOT NULL,
    [foto]           VARBINARY (MAX) NOT NULL,
    [descricao]      VARCHAR (200)   NULL,
    UNIQUE NONCLUSTERED ([id_produto] ASC)
);

