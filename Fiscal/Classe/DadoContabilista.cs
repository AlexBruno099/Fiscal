using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal.Classe
{
    public class DadoContabilista
    {
        [DisplayName("Código")]
        public int Controle { get; set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("CPF")]
        public string CPF { get;  set; }

        [DisplayName("CRC")]
        public string CRC { get; set; }

        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [DisplayName("Número")]
        public string Numero { get; set; }

        [DisplayName("Complemento")]
        public string Complemento { get; set; }

        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [DisplayName("FAX")]
        public string FAX { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Cód. Município")]
        public string CodMunicipio { get; set; }

        [DisplayName("Cód. Conta Analitica")]
        public string  CodContaAnalitica { get; set; }
    }
    public class DadoContabilistaEntityTypeConfiguration : IEntityTypeConfiguration<DadoContabilista>
    {
        public void Configure(EntityTypeBuilder<DadoContabilista> builder)
        {
            builder.ToTable("TDADOCONTABILISTA");

            builder.HasKey(e => e.Controle);

            builder.Property(e => e.Controle).HasColumnName("CONTROLE").IsRequired();

            builder.Property(e => e.Nome).HasColumnName("NOME");

            builder.Property(c => c.CPF).HasColumnName("CPF").HasMaxLength(20);

            builder.Property(c => c.CNPJ).HasColumnName("CNPJ").HasMaxLength(20);

            builder.Property(e => e.CEP).HasColumnName("CEP");

            builder.Property(e => e.Endereco).HasColumnName("ENDERECO");

            builder.Property(e => e.Numero).HasColumnName("NUMERO");

            builder.Property(e => e.Complemento).HasColumnName("COMPLEMENTO");

            builder.Property(e => e.Bairro).HasColumnName("BAIRRO");

            builder.Property(e => e.Telefone).HasColumnName("TELEFONE");

            builder.Property(e => e.Email).HasColumnName("EMAIL");

            builder.Property(e => e.CodMunicipio).HasColumnName("CODMUNCIPIO");

            builder.Property(e => e.CodContaAnalitica).HasColumnName("CODCONTAANALITICA");
        }
    }
}
