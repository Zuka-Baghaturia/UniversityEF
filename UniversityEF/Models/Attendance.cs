using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityEF.Models;

public partial class Attendance
{
    [Key]
    [Column("Attendance_ID")]
    public int AttendanceId { get; set; }

    [Column("Student_ID")]
    public int? StudentId { get; set; }

    public DateOnly? ClassDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("Teacher_ID")]
    public int? TeacherId { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("Attendances")]
    public virtual Student? Student { get; set; }

    [ForeignKey("TeacherId")]
    [InverseProperty("Attendances")]
    public virtual Teacher? Teacher { get; set; }
}
