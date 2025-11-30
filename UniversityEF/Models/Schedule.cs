using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityEF.Models;

public partial class Schedule
{
    [Key]
    [Column("Schedule_ID")]
    public int ScheduleId { get; set; }

    [Column("ClassRoom_ID")]
    public int? ClassRoomId { get; set; }

    [Column("Teacher_ID")]
    public int? TeacherId { get; set; }

    public DateOnly? ScheduleDate { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    [ForeignKey("ClassRoomId")]
    [InverseProperty("Schedules")]
    public virtual ClassRoom? ClassRoom { get; set; }

    [ForeignKey("TeacherId")]
    [InverseProperty("Schedules")]
    public virtual Teacher? Teacher { get; set; }
}
