using Microsoft.EntityFrameworkCore;
using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Data
{
    public class LMSDbContext: DbContext
    {
        public LMSDbContext(DbContextOptions<LMSDbContext> options) : base(options){
        }
        public DbSet<User> Users {  get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveBalance> LeaveBalances { get; set; }
        public DbSet<LeaveApproval> LeaveApprovals { get; set; }

    }
}
