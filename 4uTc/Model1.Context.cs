﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _4uTc
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class demoekzamen1Entities1 : DbContext
    {
        private static demoekzamen1Entities1 _context;

        public demoekzamen1Entities1()
            : base("name=demoekzamen1Entities1")
        {
        }

        public static demoekzamen1Entities1 GetContext()
        {
            if (_context == null)
                _context = new demoekzamen1Entities1();
            
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<Suppliers_Materials> Suppliers_Materials { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
