# ScienceMgr

- Mở Visual Studio 2022
- "Tool" -> "NuGet Packages Manager" -> "Package Manager Console"
- Chọn "Default project" là "ScienceMgr"
- Chạy "Update-Database -Verbose"
- Mở "SSMS" -> "(localdb)\MSSQLLocalDB", Mở và chạy file /DatabaseBackup/RestoreDbFromBak.sql
- Chạy app
