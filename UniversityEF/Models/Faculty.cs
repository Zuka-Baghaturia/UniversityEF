using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityEF.Models;

public partial class Faculty
{
    [Key]
    [Column("Faculty_ID")]
    public int FacultyId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FacultyName { get; set; }

    [InverseProperty("Faculty")]
    public virtual ICollection<ClassRoom> ClassRooms { get; set; } = new List<ClassRoom>();

    [InverseProperty("Faculty")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    [InverseProperty("Faculty")]
    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
