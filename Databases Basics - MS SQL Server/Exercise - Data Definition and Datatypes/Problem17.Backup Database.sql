BACKUP DATABASE SoftUni 
TO DISK = 'C:\Programming Courses\SoftUni\Databases Basics - MS SQL Server\softuni-backup.bak'

DROP DATABASE SoftUni

RESTORE DATABASE SoftUni  
   FROM DISK = 'C:\Programming Courses\SoftUni\Databases Basics - MS SQL Server\softuni-backup.bak'

