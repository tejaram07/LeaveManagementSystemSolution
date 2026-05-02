namespace LeaveManagementSystem.Models
{
    public class LeaveApproval: BaseEntity
    {
        public int LeaveRequestId {  get; set; }
        public int ApproverId {  get; set; }
        public int? ApprovalLevel {  get; set; }
        public int StatusId { get; set; }
        public string? Comments {  get; set; }

    }
}
