﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PoliklinikaEntities : DbContext
    {
        public PoliklinikaEntities()
            : base("name=PoliklinikaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<ClinicDepartments> ClinicDepartments { get; set; }
        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<DoctorsSchedule> DoctorsSchedule { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
