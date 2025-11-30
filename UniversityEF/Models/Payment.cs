using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityEF.Models;

public partial class Payment
{
    [Key]
    [Column("Payment_ID")]
    public int PaymentId { get; set; }

    [Column("Student_ID")]
    public int? StudentId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Amount { get; set; }

    public DateOnly? PaymentDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentType { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("Payments")]
    public virtual Student? Student { get; set; }
}
