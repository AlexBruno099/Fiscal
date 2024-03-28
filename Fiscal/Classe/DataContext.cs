using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal.Classe
{
    public class DataContext
    {
        public class ConnectionParams
        {
            public string ConnectionString()
            {
                return $"DataSource=localhost;Database=C:\\SGBR\\Master\\BD\\BASESGMASTER.FDB;Port=3045;User=SYSDBA;Password=masterkey;Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000";
            }
        }

        public class Contexto : DbContext
        {
            public DbSet<DadoContabilista> dadoContabilistas { get; set; }
            public DbSet<Emitente> emitente { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                new DadoContabilistaEntityTypeConfiguration().Configure(modelBuilder.Entity<DadoContabilista>());
                new EmitenteEntityTypeConfiguration().Configure(modelBuilder.Entity<Emitente>());
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseFirebird($"DataSource=localhost;Database=C:\\SGBR\\Master\\BD\\BASESGMASTER.FDB;Port=3050;User=SYSDBA;Password=masterkey" +
                    $";Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000");
            
        }
    }
}