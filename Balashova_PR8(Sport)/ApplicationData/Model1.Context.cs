﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Balashova_PR8_Sport_.ApplicationData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SportEntities3 : DbContext
    {
        private static SportEntities3 _context;
        public static SportEntities3 GetContext()
        {
            if (_context == null)
                _context = new SportEntities3();
            return _context;
        }
        public SportEntities3()
            : base("name=SportEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Strana> Strana { get; set; }
        public virtual DbSet<Tovar> Tovar { get; set; }
    }
}
