CREATE TABLE LeaveApprovals(
	[Id]			INT				NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[LeaveRequestId]INT				NOT NULL,
	[ApproverId]	INT				NOT NULL,
	[ApprovalLevel] INT				NULL,
	[StatusId]		INT				NOT NULL,
	[Comments]		NVARCHAR(400)	NULL,
	[CreatedOn]		DATETIME2		NOT NULL DEFAULT GETDATE(),
	[UpdatedOn]		DATETIME2		NOT NULL DEFAULT GETDATE(),
	CONSTRAINT FK_LeaveApprovals_LeaveRequestId_LeaveRequests_Id FOREIGN KEY (LeaveRequestId) REFERENCES LeaveRequests(Id),
	CONSTRAINT FK_LeaveApprovals_ApproverId_Users_Id FOREIGN KEY (ApproverId) REFERENCES Users(Id),
	CONSTRAINT FK_LeaveApprovals_StatusId_LeaveStatusTypes_Id FOREIGN KEY (StatusId) REFERENCES LeaveStatusTypes(Id))
