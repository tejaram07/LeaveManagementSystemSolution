CREATE TABLE LeaveBalances(
	[Id]				INT			NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[UserId]			INT			NOT NULL,
	[LeaveTypeId]		INT			NOT NULL,
	[Year]				INT			NOT NULL,
	[TotalAllocated]	DECIMAL		NOT NULL,
	[Availed]			DECIMAL		NOT NULL,
	[Remaining]			DECIMAL		NOT NULL,
	[CreatedOn]			DATETIME2	NOT NULL DEFAULT GETDATE(),
	[UpdatedOn]			DATETIME2	NOT NULL DEFAULT GETDATE(),
	CONSTRAINT FK_LeaveBalances_UserId_Users_Id FOREIGN KEY (UserId) REFERENCES Users(Id),
	CONSTRAINT FK_LeaveBalances_LeaveTypeId_leaveTypes_Id FOREIGN KEY (LeaveTypeId) REFERENCES LeaveTypes(Id))