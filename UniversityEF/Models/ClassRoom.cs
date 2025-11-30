using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityEF.Models;

public partial class ClassRoom
{
    [Key]
    [Column("ClassRoom_ID")]
    public int ClassRoomId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RoomNumber { get; set; }

    public int? Capacity { get; set; }

    [Column("Faculty_ID")]
    public int? FacultyId { get; set; }

    [InverseProperty("ClassRoom")]
    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    [ForeignKey("FacultyId")]
    [InverseProperty("ClassRooms")]
    public virtual Faculty? Faculty { get; set; }

    [InverseProperty("ClassRoom")]
    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    [InverseProperty("ClassRoom")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
