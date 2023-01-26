CREATE TABLE [dbo].[EmloyeeTbl]
(
	[EmpId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmpName] NCHAR(50) NOT NULL, 
    [EmpGen] NCHAR(10) NOT NULL, 
    [EmpDep] INT NOT NULL, 
    [EmpDDB] DATE NOT NULL, 
    [EmpDate] DATE NOT NULL, 
    [EmpSal] INT NOT NULL, 
    CONSTRAINT [FK1] FOREIGN KEY ([EmpDep]) REFERENCES [DepartmentTbl]([DepId])
)
