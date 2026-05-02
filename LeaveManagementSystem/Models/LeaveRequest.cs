namespace LeaveManagementSystem.Models
{
    public class LeaveRequest: BaseEntity
    {
        public int UserId { get; set; }
        public int LeaveTypeId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public double TotalDays { get; set; }
        public string Reason {  get; set; }
        public int LeaveStatusId {  get; set; }
        public DateOnly AppliedOn { get; set; }
        public bool IsHalfDay {  get; set; }
        public string? HalfDayType { get; set; }
        public ICollection<LeaveRequest> LeaveRequests { get; set; }
    }
}
