
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/10/2017 19:42:53
-- Generated from EDMX file: D:\HES\HES semestre 4\Programming\MeteoProject\MeteoWebApi\DemoWebApi\MeteoModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
--USE [MeteoDB];
--GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Localities'
CREATE TABLE [dbo].[Localities] (
    [IdLocality] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ZipCode] int  NOT NULL
);
GO

-- Creating table 'Symbols'
CREATE TABLE [dbo].[Symbols] (
    [IdSymbol] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [TypeImg] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Forecasts'
CREATE TABLE [dbo].[Forecasts] (
    [IdForecast] int IDENTITY(1,1) NOT NULL,
    [TempMin] decimal(18,0)  NOT NULL,
    [TempMax] decimal(18,0)  NOT NULL,
    [Wind] nvarchar(max)  NOT NULL,
    [Rain] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Day] nvarchar(max)  NOT NULL,
    [Locality_IdLocality] int  NOT NULL,
    [Symbol_IdSymbol] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdLocality] in table 'Localities'
ALTER TABLE [dbo].[Localities]
ADD CONSTRAINT [PK_Localities]
    PRIMARY KEY CLUSTERED ([IdLocality] ASC);
GO

-- Creating primary key on [IdSymbol] in table 'Symbols'
ALTER TABLE [dbo].[Symbols]
ADD CONSTRAINT [PK_Symbols]
    PRIMARY KEY CLUSTERED ([IdSymbol] ASC);
GO

-- Creating primary key on [IdForecast] in table 'Forecasts'
ALTER TABLE [dbo].[Forecasts]
ADD CONSTRAINT [PK_Forecasts]
    PRIMARY KEY CLUSTERED ([IdForecast] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Locality_IdLocality] in table 'Forecasts'
ALTER TABLE [dbo].[Forecasts]
ADD CONSTRAINT [FK_ForecastLocality]
    FOREIGN KEY ([Locality_IdLocality])
    REFERENCES [dbo].[Localities]
        ([IdLocality])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ForecastLocality'
CREATE INDEX [IX_FK_ForecastLocality]
ON [dbo].[Forecasts]
    ([Locality_IdLocality]);
GO

-- Creating foreign key on [Symbol_IdSymbol] in table 'Forecasts'
ALTER TABLE [dbo].[Forecasts]
ADD CONSTRAINT [FK_ForecastSymbol]
    FOREIGN KEY ([Symbol_IdSymbol])
    REFERENCES [dbo].[Symbols]
        ([IdSymbol])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ForecastSymbol'
CREATE INDEX [IX_FK_ForecastSymbol]
ON [dbo].[Forecasts]
    ([Symbol_IdSymbol]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------