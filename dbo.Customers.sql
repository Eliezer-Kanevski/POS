CREATE TABLE [dbo].[Customers] (
    [CustomerID] INT            NOT NULL,
    [Name]       NVARCHAR (50)  NOT NULL,
    [Email]      NVARCHAR (50)  NOT NULL,
    [Phone]      NVARCHAR (20)  NOT NULL,
    [Address]    NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);

