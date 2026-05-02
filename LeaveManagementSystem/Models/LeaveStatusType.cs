namespace LeaveManagementSystem.Models
{
    public class LeaveStatusType: BaseEntity
    {
        public string Name {  get; set; }
        public string Code {  get; set; }
        public ICollection<LeaveRequest> LeaveRequests { get; set; }
        public ICollection<LeaveApproval> LeaveApprovals { get; set; }
    }
}
