using EmployeeCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.DbCon;

public class DbConContext : DbContext
{
    public DbConContext(DbContextOptions<DbConContext> options) : base(options)
    {
    }
    public DbSet<TblEmpAttendance> TblEmpAttendances { get; set; }
    public DbSet<TblEmplyee> TblEmplyees { get; set; }
}
