using EntityFramework.DynamicFilters;
using System.Data.Entity;

namespace PoC.EF.TableSplitting.Model {
    public class GeneralDbContext : DbContext {
        public DbSet<Ente> Entes { get; set; }

        public DbSet<Chofer> Choferes { get; set; }

        public DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            modelBuilder.Entity<Chofer>().
                HasRequired(e => e.Ente).
                WithRequiredDependent(e => e.Chofer);

            modelBuilder.Entity<Persona>().
                HasRequired(e => e.Ente).
                WithRequiredDependent(e => e.Persona);

            modelBuilder.Filter("Choferes", (Chofer d) => d.Ente.TipoEnte == 1);
            modelBuilder.Filter("Personas", (Persona d) => d.Ente.TipoEnte == 2);
        }
    }
}
