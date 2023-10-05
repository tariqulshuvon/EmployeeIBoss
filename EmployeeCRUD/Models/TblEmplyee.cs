using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EmployeeCRUD.Models;

public class TblEmplyee
{
    [Key]
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public string EmployeeCode { get; set; }
    public string EmployeeSalary { get; set; }
    public string SupervisorId { get; set; }

}
