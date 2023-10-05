using System.Text.Json.Serialization;

namespace EmployeeCRUD.Models;

public class TblEmpAttendance 
{
    public int Id { get; set; }

    public int EmployeeeId { get; set;}


    public DateTimeOffset AttendanceDate { get; set; }

    public int IsPreset { get; set; }
    public int IsAbsent { get; set; }

    public int IsOffday { get; set; }
}
