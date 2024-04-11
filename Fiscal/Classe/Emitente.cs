using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal.Classe
{
    public class Emitente
    {
        [DisplayName("Código")]
        public int Controle { get; set; }

        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [DisplayName("Complemento")]
        public string Complemento { get; set; }

        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        [DisplayName("Código Cidade")]
        public string CodCidade { get; set; }

        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [DisplayName("UF")]
        public string UF { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("CPNJ")]
        public string CNPJ { get; set; }

        [DisplayName("IE")]
        public string IE { get; set; }

        [DisplayName("IM")]
        public string IM { get; set; }

        [DisplayName("Data Hora Cadastro")]
        public DateTime? DataHoraCadastro { get; set; }

        [DisplayName("OBS")]
        public string OBS { get; set; }

        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [DisplayName("Celular")]
        public string Celular { get; set; }

        [DisplayName("FAX")]
        public string FAX { get; set; }

        [DisplayName("Atividade")]
        public string Atividade { get; set; }

        [DisplayName("CNAE")]
        public string CNAE { get; set; }

        [DisplayName("CRT")]
        public string CRT { get; set; }

        [DisplayName("Data Fundação Empresa")]
        public DateTime? DataFundacaoEmpresa { get; set; }

        [DisplayName("País")]
        public string Pais { get; set; }

        [DisplayName("Número")]
        public string Numero { get; set; }

        [DisplayName("Código ICMS")]
        public int? CodIcms { get; set; }

        [DisplayName("Código Cidade IBGE")]
        public string CodCidadeIBGE { get; set; }

        [DisplayName("Data Movimento")]
        public DateTime? DataMovimento { get; set; }

        [DisplayName("Hora Primeiro Documento ECF")]
        public string HoraPrimeiroDocumentoECF { get; set; }

        [DisplayName("Suframa")]
        public string Suframa { get; set; }

        [DisplayName("Serie ECF")]
        public string SerieECF { get; set; }

        [DisplayName("Modelo ECF")]
        public string ModeloECF { get; set; }

        [DisplayName("Tipo ECF")]
        public string TipoECF { get; set; }

        [DisplayName("MD5")]
        public string MD5 { get; set; }

        [DisplayName("Veficado RFB")]
        public string VeficadorFB { get; set; }

        [DisplayName("Data Hora Verificação RFB")]
        public DateTime? DataHoraVerificacaoRFB { get; set; }

        [DisplayName("Captcha RFB")]
        public string CaptchaRFB { get; set; }

        [DisplayName("Retorno RFB")]
        public string RetornoRFB { get; set; }

        [DisplayName("Autorizado Uso")]
        public string AutorizadoUso { get; set; }

        [DisplayName("MD5 Cnpj Razão UFRFB")]
        public string MD5CnpjRazaoUFRFB { get; set; }

        [DisplayName("Serial Instalado")]
        public string SerialInstalado { get; set; }

        [DisplayName("Aliquota ISSQN")]
        public string AliquotaISSQN { get; set; }

        [DisplayName("Código Imposto ISS")]
        public string CodImpostoISS { get; set; }

        [DisplayName("Nota Legal DF")]
        public string NotaLegalDF { get; set; }

        [DisplayName("E3 Serie ECF")]
        public string E3SerieEcf { get; set; }

        [DisplayName("E3 Tipo ECF")]

        public string E3TipoEcf { get; set; }

        [DisplayName("E3 Marca ECF")]
        public string E3MarcaEcf { get; set; }

        [DisplayName("E3 Modelo ECF")]
        public string E3ModeloEcf { get; set; }

        [DisplayName("Atacado E Varejo")]
        public string AtacadoEVarejo { get; set; }

        [DisplayName("MD5Bos")]
        public string MD5Bos { get; set; }

        [DisplayName("MD5P")]
        public string MD5P { get; set; }

        [DisplayName("MD5L")]
        public string MD5L { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("MD5V")]
        public string MD5V { get; set; }

        [DisplayName("RNTRC")]
        public string RNTRC { get; set; }

        [DisplayName("MD5B")]
        public string MD5B { get; set; }

        [DisplayName("Site2")]
        public string Site2 { get; set; }

        [DisplayName("Regime Tributario ISSQN")]
        public string RegimeTributarioISSQN { get; set; }

        [DisplayName("Site")]
        public string Site { get; set; }

        [DisplayName("CNPJ Contador")]
        public string CNPJContador { get; set; }

        [DisplayName("Versão Servidor")]
        public int? VersaoServidor { get; set; }

        [DisplayName("Release Servidor")]
        public int? ReleaseServidor { get; set; }

        [DisplayName("Chave PP")]
        public string ChavePP { get; set; }

        [DisplayName("Controle SG")]
        public string ControleSG { get; set; }

        [DisplayName("MD5 PAF")]
        public string MD5PAF { get; set; }

        [DisplayName("Percentual de ICMS")]
        public decimal? PercICMS { get; set; }

        [DisplayName("OC")]
        public string OC { get; set; }

        [DisplayName("Data IE")]
        public DateTime? DataIE { get; set; }

        [DisplayName("Número Credenciamento")]
        public string NumeroCredenciamento { get; set; }

        [DisplayName("Possui IE Subistituto")]
        public string PossuiIESubistituto { get; set; }

        [DisplayName("Atualizar Estoque")]
        public string AtualizarEstoque { get; set; }

        [DisplayName("Comparando")]
        public string Comparando { get; set; }

        [DisplayName("Estabelecimento Unico")]
        public string EstabelecimentoUnico { get; set; }

        [DisplayName("MD5CAD")]
        public string MD5CAD { get; set; }

        [DisplayName("Atualizar Data Venda Compra")]
        public string AtualizarDataVendaCompra { get; set; }

        [DisplayName("Reservar Produto Aluguel Condi")]
        public string ReservarProdutoAluguelCondi { get; set; }

        [DisplayName("Atualizar Estoque Parcial")]
        public string AtualizarEstoqueParcial { get; set; }

        [DisplayName("Utilizar Baixa MP")]
        public string UtilizarBaixaMP { get; set; }

        [DisplayName("Número Licença")]
        public string NumLicenca { get; set; }

        [DisplayName("NumAutEspecial")]
        public string NumAutEspecial { get; set; }

        [DisplayName("Número Auto Funcionamento")]
        public string NumAutFuncionamento { get; set; }

        [DisplayName("MD5I")]
        public string MD5I { get; set; }

        [DisplayName("Sincronizado")]
        public string Sincronizado { get; set; }

        [DisplayName("Código Atividade")]
        public int? CodAtividade { get; set; }

        [DisplayName("Empresa UUIDTEF")]
        public string EmpresaUUIDTEF { get; set; }

    }
    public class EmitenteEntityTypeConfiguration : IEntityTypeConfiguration<Emitente>
    {
        public void Configure(EntityTypeBuilder<Emitente> builder)
        {
            builder.ToTable("TEMITENTE");

            builder.HasKey(e => e.Controle);

            builder.Property(e => e.Controle).HasColumnName("CONTROLE").IsRequired();

            builder.Property(e => e.NomeFantasia).HasColumnName("NOMEFANTASIA");

            builder.Property(c => c.RazaoSocial).HasColumnName("RAZAOSOCIAL");

            builder.Property(c => c.Endereco).HasColumnName("ENDERECO");

            builder.Property(e => e.Complemento).HasColumnName("COMPLEMENTO");

            builder.Property(e => e.Bairro).HasColumnName("BAIRRO");

            builder.Property(e => e.CodCidade).HasColumnName("CODCIDADE");

            builder.Property(e => e.Cidade).HasColumnName("CIDADE");

            builder.Property(e => e.UF).HasColumnName("UF");

            builder.Property(e => e.CEP).HasColumnName("CEP");

            builder.Property(e => e.CNPJ).HasColumnName("CNPJ").HasMaxLength(20);

            builder.Property(e => e.IE).HasColumnName("IE");

            builder.Property(e => e.IM).HasColumnName("IM");

            builder.Property(e => e.DataHoraCadastro).HasColumnName("DATAHORACADASTRO");

            builder.Property(c => c.OBS).HasColumnName("OBS");

            builder.Property(e => e.Telefone).HasColumnName("TELEFONE");

            builder.Property(e => e.Celular).HasColumnName("CELULAR");

            builder.Property(e => e.FAX).HasColumnName("FAX");

            builder.Property(e => e.Atividade).HasColumnName("ATIVIDADE");

            builder.Property(e => e.CNAE).HasColumnName("CNAE");

            builder.Property(e => e.CRT).HasColumnName("CRT");

            builder.Property(e => e.DataFundacaoEmpresa).HasColumnName("DATAFUNDACAOEMPRESA");

            builder.Property(e => e.Pais).HasColumnName("PAIS");

            builder.Property(e => e.Numero).HasColumnName("NUMERO");

            builder.Property(e => e.CodIcms).HasColumnName("CODICMS");

            builder.Property(e => e.CodCidadeIBGE).HasColumnName("CODCIDADEIBGE");

            builder.Property(c => c.DataFundacaoEmpresa).HasColumnName("DATAFUNDACAOEMPRESA");

            builder.Property(c => c.DataMovimento).HasColumnName("DATAMOVIMENTO");

            builder.Property(e => e.HoraPrimeiroDocumentoECF).HasColumnName("HORAPRIMEIRODOCUMENTOECF");

            builder.Property(e => e.Suframa).HasColumnName("SUFRAMA");

            builder.Property(e => e.SerieECF).HasColumnName("SERIEECF");

            builder.Property(e => e.ModeloECF).HasColumnName("MODELOECF");

            builder.Property(e => e.TipoECF).HasColumnName("TIPOECF");

            builder.Property(e => e.MD5).HasColumnName("MD5");

            builder.Property(e => e.VeficadorFB).HasColumnName("VERIFICADORFB");

            builder.Property(e => e.DataHoraVerificacaoRFB).HasColumnName("DATAHORAVERIFICACAORFB");

            builder.Property(e => e.CaptchaRFB).HasColumnName("CAPTCHARFB");

            builder.Property(e => e.RetornoRFB).HasColumnName("RETORNORFB");

            builder.Property(c => c.AutorizadoUso).HasColumnName("AUTORIZADOUSO");

            builder.Property(c => c.MD5CnpjRazaoUFRFB).HasColumnName("MD5CNPJRAZAOUFRFB");

            builder.Property(e => e.SerialInstalado).HasColumnName("SERIALINSTALADO");

            builder.Property(e => e.AliquotaISSQN).HasColumnName("ALIQUOTAISSQN");

            builder.Property(e => e.CodImpostoISS).HasColumnName("CODIMPOSTOISS");

            builder.Property(e => e.NotaLegalDF).HasColumnName("NOTALEGALDF");

            builder.Property(e => e.E3SerieEcf).HasColumnName("E3SERIEECF");

            builder.Property(e => e.E3TipoEcf).HasColumnName("E3TIPOECF");

            builder.Property(e => e.E3MarcaEcf).HasColumnName("E3MARCAECF");

            builder.Property(e => e.E3ModeloEcf).HasColumnName("E3MODELOECF");

            builder.Property(e => e.AtacadoEVarejo).HasColumnName("ATACADOEVAREJO");

            builder.Property(e => e.MD5Bos).HasColumnName("MD5BOS");

            builder.Property(e => e.MD5P).HasColumnName("MD5P");

            builder.Property(c => c.MD5L).HasColumnName("MD5L");

            builder.Property(c => c.CPF).HasColumnName("CPF");

            builder.Property(e => e.MD5V).HasColumnName("MD5V");

            builder.Property(e => e.RNTRC).HasColumnName("RNTRC");

            builder.Property(e => e.MD5B).HasColumnName("MD5B");

            builder.Property(e => e.Site2).HasColumnName("SITE2");

            builder.Property(e => e.RegimeTributarioISSQN).HasColumnName("REGIMETRIBUTARIOISSQN");

            builder.Property(e => e.Site).HasColumnName("SITE");

            builder.Property(e => e.CNPJContador).HasColumnName("CNPJCONTADOR");

            builder.Property(e => e.VersaoServidor).HasColumnName("VERSAOSERVIDOR");

            builder.Property(e => e.ReleaseServidor).HasColumnName("RELEASESERVIDOR");

            builder.Property(e => e.ChavePP).HasColumnName("CHAVEPP");

            builder.Property(c => c.ControleSG).HasColumnName("CONTROLESG").HasMaxLength(20);

            builder.Property(c => c.MD5PAF).HasColumnName("MD5PAF").HasMaxLength(20);

            builder.Property(e => e.PercICMS).HasColumnName("PERCICMS");

            builder.Property(e => e.OC).HasColumnName("OC");

            builder.Property(e => e.DataIE).HasColumnName("DATAIE");

            builder.Property(e => e.NumeroCredenciamento).HasColumnName("NUMEROCREDENCIAMENTO");

            builder.Property(e => e.PossuiIESubistituto).HasColumnName("POSSUIIESUBSTITUTO");

            builder.Property(e => e.AtualizarEstoque).HasColumnName("ATUALIZARESTOQUE");

            builder.Property(e => e.Comparando).HasColumnName("COMPARANDO");

            builder.Property(e => e.EstabelecimentoUnico).HasColumnName("ESTABELECIMENTOUNICO");

            builder.Property(e => e.MD5CAD).HasColumnName("MD5CAD");

            builder.Property(e => e.AtualizarDataVendaCompra).HasColumnName("ATUALIZARDATAVENDACOMPRA");

            builder.Property(c => c.ReservarProdutoAluguelCondi).HasColumnName("RESERVARPRODALUGUELCONDI");

            builder.Property(c => c.AtualizarEstoqueParcial).HasColumnName("ATUALIZARESTOQUEPARCIAL");

            builder.Property(e => e.UtilizarBaixaMP).HasColumnName("UTILIZARBAIXAMP");

            builder.Property(e => e.NumLicenca).HasColumnName("NUMLICENCA");

            builder.Property(e => e.NumAutEspecial).HasColumnName("NUMAUTESPECIAL");

            builder.Property(e => e.NumAutFuncionamento).HasColumnName("NUMAUTFUNCIONAMENTO");

            builder.Property(e => e.MD5I).HasColumnName("MD5I");

            builder.Property(e => e.Sincronizado).HasColumnName("SINCRONIZADO");

            builder.Property(e => e.CodAtividade).HasColumnName("CODATIVIDADE");

            builder.Property(e => e.EmpresaUUIDTEF).HasColumnName("EMPRESAUUIDTEF");
        }
    }
}
