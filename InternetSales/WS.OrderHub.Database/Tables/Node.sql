﻿CREATE TABLE [dbo].[Node]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[Name] VARCHAR(100) NOT NULL UNIQUE,
	[Description] VARCHAR(255) NULL,
	[DateCreated] DATETIME NOT NULL,
	[DateLastActive] DATETIME NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0,
    [DateDeleted] DATETIME NULL,
    [DeletedByNodeId] UNIQUEIDENTIFIER NULL FOREIGN KEY REFERENCES [dbo].[Node](Id)
)
