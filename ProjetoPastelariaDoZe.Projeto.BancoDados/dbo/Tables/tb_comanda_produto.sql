CREATE TABLE [dbo].[tb_comanda_produto] (
    [id_comanda_produto] INT             IDENTITY (1, 1) NOT NULL,
    [valor_unitario]     DECIMAL (11, 2) NOT NULL,
    [quantidade]         INT             NOT NULL,
    [comanda_id]         INT             NOT NULL,
    [produto_id]         INT             NOT NULL,
    [funcionario_id]     INT             NOT NULL,
    CONSTRAINT [PK_tb_comanda_produto] PRIMARY KEY CLUSTERED ([id_comanda_produto] ASC),
    CONSTRAINT [FK_comanda_id] FOREIGN KEY ([id_comanda_produto]) REFERENCES [dbo].[tb_comanda_produto] ([id_comanda_produto]),
    CONSTRAINT [FK_funcionario_comanda_produto] FOREIGN KEY ([funcionario_id]) REFERENCES [dbo].[tb_funcionario] ([id_funcionario]),
    CONSTRAINT [FK_produto_id] FOREIGN KEY ([produto_id]) REFERENCES [dbo].[tb_produto] ([id_produto])
);

