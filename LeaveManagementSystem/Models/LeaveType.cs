namespace LeaveManagementSystem.Models
{
    public class LeaveType: BaseEntity
    {
        public string Name {  get; set; }
        public string Code { get; set; }
        public int MaxPerYear {  get; set; }
        public bool IsCarryForward {  get; set; }
        public bool RequiresApproval { get; set; }
        public ICollection<LeaveRequest> LeaveRequests { get; set; }
        public ICollection<LeaveBalance> leaveBalances { get; set; }
    }
}
