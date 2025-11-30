using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UniversityEF.Models;

namespace UniversityEF.Data;

public partial class UniversityContext : DbContext
{
    public UniversityContext()
    {
    }

    public UniversityContext(DbContextOptions<UniversityContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<ClassRoom> ClassRooms { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-8KK9T6M;Database=SQL_Project;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.AttendanceId).HasName("PK__Attendan__57FA49344B4803F2");

            entity.Property(e => e.AttendanceId).ValueGeneratedNever();

            entity.HasOne(d => d.Student).WithMany(p => p.Attendances).HasConstraintName("FK__Attendanc__Stude__73BA3083");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Attendances).HasConstraintName("FK__Attendanc__Teach__74AE54BC");
        });

        modelBuilder.Entity<ClassRoom>(entity =>
        {
            entity.HasKey(e => e.ClassRoomId).HasName("PK__ClassRoo__9CFC49959AAAE35A");

            entity.Property(e => e.ClassRoomId).ValueGeneratedNever();

            entity.HasOne(d => d.Faculty).WithMany(p => p.ClassRooms).HasConstraintName("FK__ClassRoom__Facul__619B8048");
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.ExamId).HasName("PK__Exams__C782CA795C237C62");

            entity.Property(e => e.ExamId).ValueGeneratedNever();

            entity.HasOne(d => d.ClassRoom).WithMany(p => p.Exams).HasConstraintName("FK__Exams__ClassRoom__68487DD7");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Exams).HasConstraintName("FK__Exams__Teacher_I__6754599E");
        });

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.HasKey(e => e.FacultyId).HasName("PK__Facultie__4EFCEA4A72B2BF53");

            entity.Property(e => e.FacultyId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.GradeId).HasName("PK__Grades__D44371537BD1F720");

            entity.Property(e => e.GradeId).ValueGeneratedNever();

            entity.HasOne(d => d.Exam).WithMany(p => p.Grades).HasConstraintName("FK__Grades__Exam_ID__7F2BE32F");

            entity.HasOne(d => d.Student).WithMany(p => p.Grades).HasConstraintName("FK__Grades__Student___7E37BEF6");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payments__DA6C7FE1E9FDFAEA");

            entity.Property(e => e.PaymentId).ValueGeneratedNever();

            entity.HasOne(d => d.Student).WithMany(p => p.Payments).HasConstraintName("FK__Payments__Studen__02FC7413");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK__Schedule__8C4D3BBB244BB815");

            entity.Property(e => e.ScheduleId).ValueGeneratedNever();

            entity.HasOne(d => d.ClassRoom).WithMany(p => p.Schedules).HasConstraintName("FK__Schedules__Class__7A672E12");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Schedules).HasConstraintName("FK__Schedules__Teach__7B5B524B");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Students__A2F4E9AC82E09FC0");

            entity.Property(e => e.StudentId).ValueGeneratedNever();

            entity.HasOne(d => d.ClassRoom).WithMany(p => p.Students).HasConstraintName("FK__Students__ClassR__6E01572D");

            entity.HasOne(d => d.Exam).WithMany(p => p.Students).HasConstraintName("FK__Students__Exam_I__6C190EBB");

            entity.HasOne(d => d.Faculty).WithMany(p => p.Students).HasConstraintName("FK__Students__Facult__6D0D32F4");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Students).HasConstraintName("FK__Students__Teache__6B24EA82");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__Subjects__D98F54D6F4F4C2DE");

            entity.Property(e => e.SubjectId).ValueGeneratedNever();

            entity.HasOne(d => d.Teacher).WithMany(p => p.Subjects).HasConstraintName("FK__Subjects__Teache__778AC167");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("PK__Teachers__92FF4C8B6E0F0735");

            entity.Property(e => e.TeacherId).ValueGeneratedNever();

            entity.HasOne(d => d.Faculty).WithMany(p => p.Teachers).HasConstraintName("FK__Teachers__Facult__6477ECF3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
