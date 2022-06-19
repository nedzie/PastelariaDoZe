CREATE TABLE [dbo].[tb_cliente] (
    [id_cliente]   INT           IDENTITY (1, 1) NOT NULL,
    [nome]         VARCHAR (120) NOT NULL,
    [cpf]          CHAR (11)     NULL,
    [telefone]     CHAR (11)     NULL,
    [senha]        VARCHAR (MAX) NULL,
    [compra_fiado] TINYINT       NULL,
    [dia_fiado]    INT           NULL,
    [cnpj]         VARCHAR (14)  NULL,
    UNIQUE NONCLUSTERED ([id_cliente] ASC)
);

