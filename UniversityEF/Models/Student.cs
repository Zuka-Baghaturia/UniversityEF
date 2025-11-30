using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityEF.Models;

public partial class Student
{
    [Key]
    [Column("Student_ID")]
    public int StudentId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    public DateOnly? BirthDate { get; set; }

    public int? Age { get; set; }

    [Column("Phone_Number")]
    [StringLength(40)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    [Column("Teacher_ID")]
    public int? TeacherId { get; set; }

    [Column("Exam_ID")]
    public int? ExamId { get; set; }

    [Column("Faculty_ID")]
    public int? FacultyId { get; set; }

    [Column("ClassRoom_ID")]
    public int? ClassRoomId { get; set; }

    [InverseProperty("Student")]
    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    [ForeignKey("ClassRoomId")]
    [InverseProperty("Students")]
    public virtual ClassRoom? ClassRoom { get; set; }

    [ForeignKey("ExamId")]
    [InverseProperty("Students")]
    public virtual Exam? Exam { get; set; }

    [ForeignKey("FacultyId")]
    [InverseProperty("Students")]
    public virtual Faculty? Faculty { get; set; }

    [InverseProperty("Student")]
    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    [InverseProperty("Student")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [ForeignKey("TeacherId")]
    [InverseProperty("Students")]
    public virtual Teacher? Teacher { get; set; }
}
