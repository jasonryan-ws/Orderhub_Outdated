﻿CREATE TABLE [dbo].[Task]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(25) UNIQUE NOT NULL, 
    [Description] VARCHAR(255) NULL

)
