//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class restauranteEntities1 : DbContext
    {
        public restauranteEntities1()
            : base("name=restauranteEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<comenzales> comenzales { get; set; }
        public virtual DbSet<ingredientes> ingredientes { get; set; }
        public virtual DbSet<receta> receta { get; set; }
        public virtual DbSet<trabajdores> trabajdores { get; set; }
    }
}
