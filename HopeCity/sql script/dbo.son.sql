USE [C:\USERS\LENOVO\DESKTOP\HOPECITY\HOPECITY\HOPECITY\HCDB1.MDF]
GO

/****** Object: Table [dbo].[son] Script Date: 05-Mar-20 6:05:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[son] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [date]       NVARCHAR (50) NULL,
    [name]       NVARCHAR (50) NULL,
    [gender]     NVARCHAR (50) NULL,
    [dob]        NVARCHAR (50) NULL,
    [age]        NVARCHAR (50) NULL,
    [nat]        NVARCHAR (50) NULL,
    [nos]        NVARCHAR (50) NULL,
    [orderrr]    NVARCHAR (50) NULL,
    [address]    NVARCHAR (50) NULL,
    [djob]       NVARCHAR (50) NULL,
    [dedu]       NVARCHAR (50) NULL,
    [daddress]   NVARCHAR (50) NULL,
    [dtelephone] NVARCHAR (50) NULL,
    [dmobile]    NVARCHAR (50) NULL,
    [mname]      NVARCHAR (50) NULL,
    [mjob]       NVARCHAR (50) NULL,
    [medu]       NVARCHAR (50) NULL,
    [maddress]   NVARCHAR (50) NULL,
    [mmobile]    NVARCHAR (50) NULL,
    [withdad]    BIT           NULL,
    [withmom]    BIT           NULL,
    [withother]  BIT           NULL,
    [whocare]    NVARCHAR (50) NULL,
    [problem]    NVARCHAR (50) NULL
);


