namespace LeaveManagementSystem.Models
{
    public class Role: BaseEntity
    {
        public string Name {  get; set; }
        public string Code {  get; set; }
        public string Description { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
