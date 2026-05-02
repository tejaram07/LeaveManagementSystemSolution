namespace LeaveManagementSystem.Models
{
    public class LeaveBalance: BaseEntity
    {
        public int UserId {  get; set; }
        public int LeaveTypeId {  get; set; }
        public int Year {  get; set; }
        public double TotalAllocated {  get; set; }
        public double Availed {  get; set; }
        public double Remaining {  get; set; }
    }
}
