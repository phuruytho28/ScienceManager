USE [master];
GO
RESTORE DATABASE [ScientMgrDb]
-- Paste .bak file path here
FROM DISK = N'C:\Users\hoannk\source\repos\ScienceMgr\backup\ScientMgrDb.bak' WITH  FILE = 1, NOUNLOAD, STATS = 5;
GO
