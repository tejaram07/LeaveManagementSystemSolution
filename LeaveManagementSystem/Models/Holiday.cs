namespace LeaveManagementSystem.Models
{
    public class Holiday: BaseEntity
    {
        public string Name {  get; set; }
        public DateOnly Date { get; set; }
    }
}
