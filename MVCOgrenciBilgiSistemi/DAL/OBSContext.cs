using MVCOgrenciBilgiSistemi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVCOgrenciBilgiSistemi.DAL
{
    public class OBSContext : DbContext
    {
        public OBSContext() : base("OBSVeritabani") { }
        public DbSet<Fakulte> Fakulteler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}