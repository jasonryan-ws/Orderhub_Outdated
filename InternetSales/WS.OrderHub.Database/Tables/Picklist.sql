﻿CREATE TABLE [dbo].[Picklist]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1001,1), 
    [PrintCount] INT NOT NULL DEFAULT 0, 
    [DateCreated] DATETIME NOT NULL, 
    [CreatedByNodeID] UNIQUEIDENTIFIER NOT NULL

)