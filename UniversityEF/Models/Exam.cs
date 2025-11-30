using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityEF.Models;

public partial class Exam
{
    [Key]
    [Column("Exam_ID")]
    public int ExamId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Subject { get; set; }

    public DateOnly? ExamDate { get; set; }

    [Column("Teacher_ID")]
    public int? TeacherId { get; set; }

    [Column("ClassRoom_ID")]
    public int? ClassRoomId { get; set; }

    [ForeignKey("ClassRoomId")]
    [InverseProperty("Exams")]
    public virtual ClassRoom? ClassRoom { get; set; }

    [InverseProperty("Exam")]
    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    [InverseProperty("Exam")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    [ForeignKey("TeacherId")]
    [InverseProperty("Exams")]
    public virtual Teacher? Teacher { get; set; }
}
