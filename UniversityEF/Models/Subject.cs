using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityEF.Models;

public partial class Subject
{
    [Key]
    [Column("Subject_ID")]
    public int SubjectId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SubjectName { get; set; }

    [Column("Teacher_ID")]
    public int? TeacherId { get; set; }

    [ForeignKey("TeacherId")]
    [InverseProperty("Subjects")]
    public virtual Teacher? Teacher { get; set; }
}
