CREATE TABLE [dbo].[SalaryTbl]
(
	[SCode] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Employee] INT NOT NULL, 
    [Attendance] INT NOT NULL, 
    [Period] NCHAR(100) NOT NULL, 
    [Amount] INT NOT NULL, 
    [PayDate] DATE NOT NULL, 
    CONSTRAINT [FK3] FOREIGN KEY ([Employee]) REFERENCES [EmployeeTbl]([EmoId])
)
