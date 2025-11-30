using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityEF.Models;

public partial class Grade
{
    [Key]
    [Column("Grade_ID")]
    public int GradeId { get; set; }

    [Column("Student_ID")]
    public int? StudentId { get; set; }

    [Column("Exam_ID")]
    public int? ExamId { get; set; }

    [Column(TypeName = "decimal(4, 2)")]
    public decimal? GradeValue { get; set; }

    public DateOnly? GradeDate { get; set; }

    [ForeignKey("ExamId")]
    [InverseProperty("Grades")]
    public virtual Exam? Exam { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("Grades")]
    public virtual Student? Student { get; set; }
}
