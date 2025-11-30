using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityEF.Models;

public partial class Teacher
{
    [Key]
    [Column("Teacher_ID")]
    public int TeacherId { get; set; }

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

    [StringLength(100)]
    [Unicode(false)]
    public string? Subject { get; set; }

    [Column("Faculty_ID")]
    public int? FacultyId { get; set; }

    [InverseProperty("Teacher")]
    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    [InverseProperty("Teacher")]
    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    [ForeignKey("FacultyId")]
    [InverseProperty("Teachers")]
    public virtual Faculty? Faculty { get; set; }

    [InverseProperty("Teacher")]
    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    [InverseProperty("Teacher")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    [InverseProperty("Teacher")]
    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
