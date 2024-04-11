using Fiscal.Classe;
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
    public class TVendaNFe
    {
            [DisplayName("CONTROLE")]
            public int Controle { get; set; }

            [DisplayName("DATACADASTRO")]
            public DateTime? DataCadastro { get; set; }

            [DisplayName("HORACADASTRO")]
            public TimeSpan? HoraCadastro { get; set; }

            [DisplayName("NOTA")]
            public string Nota { get; set; }

            [DisplayName("SERIE")]
            public string Serie { get; set; }

            [DisplayName("DATAEMISSAO")]
            public DateTime? DataEmissao { get; set; }

            [DisplayName("DATASAIDAEMTRADA")]
            public DateTime? DataSaidaEntrada { get; set; }

            [DisplayName("HORAENTRADASAIDA")]
            public TimeSpan? HoraEntradaSaida { get; set; }

            [DisplayName("CANCELADA")]
            public string Cancelada { get; set; }

            [DisplayName("INUTILIZADA")]
            public string Inutilizada { get; set; }

            [DisplayName("DENEGADA")]
            public string Denegada { get; set; }

            [DisplayName("CHAVEACESSO")]
            public string ChaveAcesso { get; set; }

            [DisplayName("PROTOCOLO")]
            public string Protocolo { get; set; }

            [DisplayName("STATUSDEENVIO")]
            public string StatusEnvio { get; set; }

            [DisplayName("IDENTIFICACAOAMBIENTE")]
            public string IdentificacaoAmbiente { get; set; }

            [DisplayName("CODOPERACAO")]
            public int? CodOperacao { get; set; }

            [DisplayName("NATUREZAOPERACAO")]
            public string NaturezaOperacao { get; set; }

            [DisplayName("FINALIDADEOPERACAO")]
            public string FinalidadeOperacao { get; set; }

            [DisplayName("TIPOOPERACAO")]
            public string TipoOperacao { get; set; }

            [DisplayName("TIPOEMISSAO")]
            public string TipoEmissao { get; set; }

            [DisplayName("FINALIDADEEMISSAO")]
            public string FinalidadeEmissao { get; set; }

            [DisplayName("CODFUNCIONARIO")]
            public int? CodFuncionario { get; set; }

            [DisplayName("FUNCIONARIO")]
            public string Funcionario { get; set; }

            [DisplayName("CODVENDEDOR")]
            public int? CodVendedor { get; set; }

            [DisplayName("VENDEDOR")]
            public string Vendedor { get; set; }

            [DisplayName("TIPODEVENDA")]
            public string TipoDeVenda { get; set; }

            [DisplayName("CODCLIENTE")]
            public int? CodCliente { get; set; }

            [DisplayName("CODFORNECEDOR")]
            public int? CodFornecedor { get; set; }

            [DisplayName("CNPJDESTINATARIO")]
            public string CNPJDestinatario { get; set; }

            [DisplayName("CPFDESTINATARIO")]
            public string CPFDestinatario { get; set; }

            [DisplayName("RAZAOSOCIALDESTINATARIO")]
            public string RazaoSocialDestinatario { get; set; }

            [DisplayName("ENDERECODESTINATARIO")]
            public string EnderecoDestinatario { get; set; }

            [DisplayName("NUMERODESTINATARIO")]
            public string NumeroDestinatario { get; set; }

            [DisplayName("BAIRRODESTINATARIO")]
            public string BairroDestinatario { get; set; }

            [DisplayName("CODCIDADEDESTINATARIO")]
            public int? CodCidadeDestinatario { get; set; }

            [DisplayName("CIDADEDESTINATARIO")]
            public string CidadeDestinatario { get; set; }

            [DisplayName("CODIGOMUNICIPIO")]
            public string CodigoMunicipio { get; set; }

            [DisplayName("UFDESTINATARIO")]
            public string UFDestinatario { get; set; }

            [DisplayName("IEDESTINATARIO")]
            public string IEDestinatario { get; set; }

            [DisplayName("CEPDESTINATARIO")]
            public string CEPDestinatario { get; set; }

            [DisplayName("PAISDESTINATARIO")]
            public string PaisDestinatario { get; set; }

            [DisplayName("TELEFONEDESTINATARIO")]
            public string TelefoneDestinatario { get; set; }

            [DisplayName("EMAILDESTINATARIO")]
            public string EmailDestinatario { get; set; }

            [DisplayName("CODTRANSPORTADORA")]
            public int? CodTransportadora { get; set; }

            [DisplayName("CPFTRANSPORTADORA")]
            public string CPFTransportadora { get; set; }

            [DisplayName("CNPJTRANSPORTADORA")]
            public string CNPJTransportadora { get; set; }

            [DisplayName("IETRANSPORTADORA")]
            public string IETransportadora { get; set; }

            [DisplayName("ENDERECOTRANSPORTADORA")]
            public string EnderecoTransportadora { get; set; }

            [DisplayName("UFTRANSPORTADORA")]
            public string UFTransportadora { get; set; }

            [DisplayName("CIDADETRANSPORTADORA")]
            public string CidadeTransportadora { get; set; }

            [DisplayName("ANTTTRANSPORTADORA")]
            public string ANTTransportadora { get; set; }

            [DisplayName("PLACATRANSPORTADORA")]
            public string PlacaTransportadora { get; set; }

            [DisplayName("UFPLACA")]
            public string UFPlaca { get; set; }

            [DisplayName("QUANTIDADE")]
            public decimal? Quantidade { get; set; }

            [DisplayName("ESPECIE")]
            public string Especie { get; set; }

            [DisplayName("MARCA")]
            public string Marca { get; set; }

            [DisplayName("NUMERACAO")]
            public string Numeracao { get; set; }

            [DisplayName("PESOBRUTO")]
            public decimal? PesoBruto { get; set; }

            [DisplayName("PESOLIQUIDO")]
            public decimal? PesoLiquido { get; set; }

            [DisplayName("BASECALCULOICMS")]
            public decimal? BaseCalculoICMS { get; set; }

            [DisplayName("VALORTOTALICMS")]
            public decimal? ValorTotalICMS { get; set; }

            [DisplayName("VALORTOTALBCSERVICO")]
            public decimal? ValorTotalBCServico { get; set; }

            [DisplayName("TOTALISS")]
            public decimal? TotalISS { get; set; }

            [DisplayName("BASECALCULOICMSST")]
            public decimal? BaseCalculoICMSST { get; set; }

            [DisplayName("VALORTOTALICMSST")]
            public decimal? ValorTotalICMSST { get; set; }

            [DisplayName("VALORTOTALFRETE")]
            public decimal? ValorTotalFrete { get; set; }

            [DisplayName("VALORTOTALSEGURO")]
            public decimal? ValorTotalSeguro { get; set; }

            [DisplayName("VALORTOTALDESCONTO")]
            public decimal? ValorTotalDesconto { get; set; }

            [DisplayName("VALORDESCONTOITEM")]
            public decimal? ValorDescontoItem { get; set; }

            [DisplayName("VALORTOTALII")]
            public decimal? ValorTotalII { get; set; }

            [DisplayName("VALORTOTALIPI")]
            public decimal? ValorTotalIPI { get; set; }

            [DisplayName("VALORTOTALPIS")]
            public decimal? ValorTotalPIS { get; set; }

            [DisplayName("VALORTOTALPISRET")]
            public decimal? ValorTotalPISRet { get; set; }

            [DisplayName("VALORTOTALCOFINS")]
            public decimal? ValorTotalCOFINS { get; set; }

            [DisplayName("VALORTOTALCOFINSRET")]
            public decimal? ValorTotalCOFINSRet { get; set; }

            [DisplayName("VALORTOTALCSLLRET")]
            public decimal? ValorTotalCSLLRet { get; set; }

            [DisplayName("VALORTOTALBCIRRF")]
            public decimal? ValorTotalBCIRRF { get; set; }

            [DisplayName("VALORTOTALIRRF")]
            public decimal? ValorTotalIRRF { get; set; }

            [DisplayName("VALORTOTALBCPREVRET")]
            public decimal? ValorTotalBCPrevRet { get; set; }

            [DisplayName("VALORTOTALPREVRET")]
            public decimal? ValorTotalPrevRet { get; set; }

            [DisplayName("VALORICMSUFDEST")]
            public decimal? ValorICMSUFDest { get; set; }

            [DisplayName("VALORICMSUFREMET")]
            public decimal? ValorICMSUFRemet { get; set; }

            [DisplayName("OUTRASDESPESAS")]
            public decimal? OutrasDespesas { get; set; }

            [DisplayName("TOTALCUSTOPRODUTO")]
            public decimal? TotalCustoProduto { get; set; }

            [DisplayName("TOTALPRODUTOS")]
            public decimal? TotalProdutos { get; set; }

            [DisplayName("TOTALSERVICO")]
            public decimal? TotalServico { get; set; }

            [DisplayName("VALORTOTALNFE")]
            public decimal? ValorTotalNFe { get; set; }

            [DisplayName("VALORENTRADA")]
            public decimal? ValorEntrada { get; set; }

            [DisplayName("PERCIMPOSTOMEDIO")]
            public decimal? PercImpostoMedio { get; set; }

            [DisplayName("VALORIMPOSTOMEDIO")]
            public decimal? ValorImpostoMedio { get; set; }

            [DisplayName("INFORMACOESCOMPLEMENTARES")]
            public string InformacoesComplementares { get; set; }

            [DisplayName("INFORMACOESFISCO")]
            public string InformacoesFisco { get; set; }

            [DisplayName("RAZAOSOCIALTRANSPORTADORA")]
            public string RazaoSocialTransportadora { get; set; }

            [DisplayName("MODELO")]
            public string Modelo { get; set; }

            [DisplayName("FORMATOIMPRESSAO")]
            public string FormatoImpressao { get; set; }

            [DisplayName("CPFEMITENTE")]
            public string CPFEmitente { get; set; }

            [DisplayName("CONTINGENCIA")]
            public string Contingencia { get; set; }

            [DisplayName("INDICADORPAGAMENTO")]
            public string IndicadorPagamento { get; set; }

            [DisplayName("CODOS")]
            public int? CodOS { get; set; }

            [DisplayName("CODORCAMENTO")]
            public int? CodOrcamento { get; set; }

            [DisplayName("CHECADO")]
            public string Checado { get; set; }

            [DisplayName("CODCONDICIONAL")]
            public int? CodCondicional { get; set; }

            [DisplayName("UFEMBARQUE")]
            public string UFEembarque { get; set; }

            [DisplayName("LOCALEMBARQUE")]
            public string LocalEmbarque { get; set; }

            [DisplayName("CODCCFECF")]
            public int? CodCCFECF { get; set; }

            [DisplayName("CODPEDIDOVENDA")]
            public int? CodPedidoVenda { get; set; }

            [DisplayName("ESPECIEPAGAMENTO")]
            public string EspeciePagamento { get; set; }

            [DisplayName("INFORMACAOFISCAL")]
            public string InformacaoFiscal { get; set; }

            [DisplayName("IDESTRANGEIRO")]
            public string IDEstrangeiro { get; set; }

            [DisplayName("STATUS")]
            public string Status { get; set; }

            [DisplayName("MODOFRETE")]
            public string ModoFrete { get; set; }

            [DisplayName("AVISTA")]
            public string AVista { get; set; }

            [DisplayName("JAFATURADA")]
            public string JAFaturada { get; set; }

            [DisplayName("SEQUENCIACCE")]
            public int? SequenciaCCE { get; set; }

            [DisplayName("CODIGOSTATUSCANCELAMENTO")]
            public string CodigoStatusCancelamento { get; set; }

            [DisplayName("DATAEHORACANCELAMENTO")]
            public DateTime? DataHoraCancelamento { get; set; }

            [DisplayName("PROTOCOLOCANCELAMENTO")]
            public string ProtocoloCancelamento { get; set; }

            [DisplayName("JUSTIFICATIVA")]
            public string Justificativa { get; set; }

            [DisplayName("MOTIVOCANCELAMENTO")]
            public string MotivoCancelamento { get; set; }

            [DisplayName("INDICADOR")]
            public string Indicador { get; set; }

            [DisplayName("NUMERONOTA")]
            public string NumeroNota { get; set; }

            [DisplayName("CODPRODUTO")]
            public int? CodProduto { get; set; }

            [DisplayName("MD5J1")]
            public string MD5J1 { get; set; }

            [DisplayName("VALORTOTALFCPST")]
            public decimal? ValorTotalFCPST { get; set; }

            [DisplayName("INDCONSUMIDORFINAL")]
            public string IndConsumidorFinal { get; set; }

            [DisplayName("CODNOTAMANUAL")]
            public int? CodNotaManual { get; set; }

            [DisplayName("VERIFICADO")]
            public string Verificado { get; set; }

            [DisplayName("CNAE")]
            public string CNAE { get; set; }

            [DisplayName("CNF")]
            public string CNF { get; set; }

            [DisplayName("NUMEROCOMPRA")]
            public string NumeroCompra { get; set; }
    }

}
    public class TVendaNFeEntityTypeConfiguration : IEntityTypeConfiguration<TVendaNFe>
    {
        public void Configure(EntityTypeBuilder<TVendaNFe> builder)
        {
            builder.ToTable("TVENDANFE");

            builder.HasKey(C => C.Controle);

            builder.Property(e => e.Controle).HasColumnName("CONTROLE").IsRequired();

            builder.Property(e => e.DataCadastro).HasColumnName("DATACADASTRO");

            builder.Property(e => e.HoraCadastro).HasColumnName("HORACADASTRO");

        builder.Property(e => e.Nota).HasColumnName("NOTA");

        builder.Property(e => e.Serie).HasColumnName("SERIE");

        builder.Property(e => e.DataEmissao).HasColumnName("DATAEMISSAO");

        builder.Property(e => e.DataSaidaEntrada).HasColumnName("DATASAIDAEMTRADA");

        builder.Property(e => e.HoraEntradaSaida).HasColumnName("HORAENTRADASAIDA");

        builder.Property(e => e.Cancelada).HasColumnName("CANCELADA");

        builder.Property(e => e.Inutilizada).HasColumnName("INUTILIZADA");

        builder.Property(e => e.Denegada).HasColumnName("DENEGADA");

        builder.Property(e => e.ChaveAcesso).HasColumnName("CHAVEACESSO");

        builder.Property(e => e.Protocolo).HasColumnName("PROTOCOLO");

        builder.Property(e => e.StatusEnvio).HasColumnName("STATUSDEENVIO");

        builder.Property(e => e.IdentificacaoAmbiente).HasColumnName("IDENTIFICACAOAMBIENTE");

        builder.Property(e => e.CodOperacao).HasColumnName("CODOPERACAO");

        builder.Property(e => e.NaturezaOperacao).HasColumnName("NATUREZAOPERACAO");

        builder.Property(e => e.FinalidadeOperacao).HasColumnName("FINALIDADEOPERACAO");

        builder.Property(e => e.TipoOperacao).HasColumnName("TIPOOPERACAO");

        builder.Property(e => e.TipoEmissao).HasColumnName("TIPOEMISSAO");

        builder.Property(e => e.FinalidadeEmissao).HasColumnName("FINALIDADEEMISSAO");

        builder.Property(e => e.CodFuncionario).HasColumnName("CODFUNCIONARIO");

        builder.Property(e => e.Funcionario).HasColumnName("FUNCIONARIO");

        builder.Property(e => e.CodVendedor).HasColumnName("CODVENDEDOR");

        builder.Property(e => e.Vendedor).HasColumnName("VENDEDOR");

        builder.Property(e => e.TipoDeVenda).HasColumnName("TIPODEVENDA");

        builder.Property(e => e.CodCliente).HasColumnName("CODCLIENTE");

        builder.Property(e => e.CodFornecedor).HasColumnName("CODFORNECEDOR");

        builder.Property(e => e.CNPJDestinatario).HasColumnName("CNPJDESTINATARIO");

        builder.Property(e => e.CPFDestinatario).HasColumnName("CPFDESTINATARIO");

        builder.Property(e => e.RazaoSocialDestinatario).HasColumnName("RAZAOSOCIALDESTINATARIO");

        builder.Property(e => e.EnderecoDestinatario).HasColumnName("ENDERECODESTINATARIO");

        builder.Property(e => e.NumeroDestinatario).HasColumnName("NUMERODESTINATARIO");

        builder.Property(e => e.BairroDestinatario).HasColumnName("BAIRRODESTINATARIO");

        builder.Property(e => e.CodCidadeDestinatario).HasColumnName("CODCIDADEDESTINATARIO");

        builder.Property(e => e.CidadeDestinatario).HasColumnName("CIDADEDESTINATARIO");

        builder.Property(e => e.CodigoMunicipio).HasColumnName("CODIGOMUNICIPIO");

        builder.Property(e => e.UFDestinatario).HasColumnName("UFDESTINATARIO");

        builder.Property(e => e.IEDestinatario).HasColumnName("IEDESTINATARIO");

        builder.Property(e => e.CEPDestinatario).HasColumnName("CEPDESTINATARIO");

        builder.Property(e => e.PaisDestinatario).HasColumnName("PAISDESTINATARIO");

        builder.Property(e => e.TelefoneDestinatario).HasColumnName("TELEFONEDESTINATARIO");

        builder.Property(e => e.EmailDestinatario).HasColumnName("EMAILDESTINATARIO");

        builder.Property(e => e.CodTransportadora).HasColumnName("CODTRANSPORTADORA");

        builder.Property(e => e.CPFTransportadora).HasColumnName("CPFTRANSPORTADORA");

        builder.Property(e => e.CNPJTransportadora).HasColumnName("CNPJTRANSPORTADORA");

        builder.Property(e => e.IETransportadora).HasColumnName("IETRANSPORTADORA");

        builder.Property(e => e.EnderecoTransportadora).HasColumnName("ENDERECOTRANSPORTADORA");

        builder.Property(e => e.UFTransportadora).HasColumnName("UFTRANSPORTADORA");

        builder.Property(e => e.CidadeTransportadora).HasColumnName("CIDADETRANSPORTADORA");

        builder.Property(e => e.ANTTransportadora).HasColumnName("ANTTTRANSPORTADORA");

        builder.Property(e => e.PlacaTransportadora).HasColumnName("PLACATRANSPORTADORA");

        builder.Property(e => e.UFPlaca).HasColumnName("UFPLACA");

        builder.Property(e => e.Quantidade).HasColumnName("QUANTIDADE");

        builder.Property(e => e.Especie).HasColumnName("ESPECIE");

        builder.Property(e => e.Marca).HasColumnName("MARCA");

        builder.Property(e => e.Numeracao).HasColumnName("NUMERACAO");

        builder.Property(e => e.PesoBruto).HasColumnName("PESOBRUTO");

        builder.Property(e => e.PesoLiquido).HasColumnName("PESOLIQUIDO");

        builder.Property(e => e.BaseCalculoICMS).HasColumnName("BASECALCULOICMS");

        builder.Property(e => e.ValorTotalICMS).HasColumnName("VALORTOTALICMS");

        builder.Property(e => e.ValorTotalBCServico).HasColumnName("VALORTOTALBCSERVICO");

        builder.Property(e => e.TotalISS).HasColumnName("TOTALISS");

        builder.Property(e => e.BaseCalculoICMSST).HasColumnName("BASECALCULOICMSST");

        builder.Property(e => e.ValorTotalICMSST).HasColumnName("VALORTOTALICMSST");

        builder.Property(e => e.ValorTotalFrete).HasColumnName("VALORTOTALFRETE");

        builder.Property(e => e.ValorTotalSeguro).HasColumnName("VALORTOTALSEGURO");

        builder.Property(e => e.ValorTotalDesconto).HasColumnName("VALORTOTALDESCONTO");

        builder.Property(e => e.ValorDescontoItem).HasColumnName("VALORDESCONTOITEM");

        builder.Property(e => e.ValorTotalII).HasColumnName("VALORTOTALII");

        builder.Property(e => e.ValorTotalIPI).HasColumnName("VALORTOTALIPI");

        builder.Property(e => e.ValorTotalPIS).HasColumnName("VALORTOTALPIS");

        builder.Property(e => e.ValorTotalPISRet).HasColumnName("VALORTOTALPISRET");

        builder.Property(e => e.ValorTotalCOFINS).HasColumnName("VALORTOTALCOFINS");

        builder.Property(e => e.ValorTotalCOFINSRet).HasColumnName("VALORTOTALCOFINSRET");

        builder.Property(e => e.ValorTotalCSLLRet).HasColumnName("VALORTOTALCSLLRET");

        builder.Property(e => e.ValorTotalBCIRRF).HasColumnName("VALORTOTALBCIRRF");

        builder.Property(e => e.ValorTotalIRRF).HasColumnName("VALORTOTALIRRF");

        builder.Property(e => e.ValorTotalBCPrevRet).HasColumnName("VALORTOTALBCPREVRET");

        builder.Property(e => e.ValorTotalPrevRet).HasColumnName("VALORTOTALPREVRET");

        builder.Property(e => e.ValorICMSUFDest).HasColumnName("VALORICMSUFDEST");

        builder.Property(e => e.ValorICMSUFRemet).HasColumnName("VALORICMSUFREMET");

        builder.Property(e => e.OutrasDespesas).HasColumnName("OUTRASDESPESAS");

        builder.Property(e => e.TotalCustoProduto).HasColumnName("TOTALCUSTOPRODUTO");

        builder.Property(e => e.TotalProdutos).HasColumnName("TOTALPRODUTOS");

        builder.Property(e => e.TotalServico).HasColumnName("TOTALSERVICO");

        builder.Property(e => e.ValorTotalNFe).HasColumnName("VALORTOTALNFE");

        builder.Property(e => e.ValorEntrada).HasColumnName("VALORENTRADA");

        builder.Property(e => e.PercImpostoMedio).HasColumnName("PERCIMPOSTOMEDIO");

        builder.Property(e => e.ValorImpostoMedio).HasColumnName("VALORIMPOSTOMEDIO");

        builder.Property(e => e.InformacoesComplementares).HasColumnName("INFORMACOESCOMPLEMENTARES");

        builder.Property(e => e.InformacoesFisco).HasColumnName("INFORMACOESFISCO");

        builder.Property(e => e.RazaoSocialTransportadora).HasColumnName("RAZAOSOCIALTRANSPORTADORA");

        builder.Property(e => e.Modelo).HasColumnName("MODELO");

        builder.Property(e => e.FormatoImpressao).HasColumnName("FORMATOIMPRESSAO");

        builder.Property(e => e.CPFEmitente).HasColumnName("CPFEMITENTE");

        builder.Property(e => e.Contingencia).HasColumnName("CONTINGENCIA");

        builder.Property(e => e.IndicadorPagamento).HasColumnName("INDICADORPAGAMENTO");

        builder.Property(e => e.CodOS).HasColumnName("CODOS");

        builder.Property(e => e.CodOrcamento).HasColumnName("CODORCAMENTO");

        builder.Property(e => e.Checado).HasColumnName("CHECADO");

        builder.Property(e => e.CodCondicional).HasColumnName("CODCONDICIONAL");

        builder.Property(e => e.UFEembarque).HasColumnName("UFEMBARQUE");

        builder.Property(e => e.LocalEmbarque).HasColumnName("LOCALEMBARQUE");

        builder.Property(e => e.CodCCFECF).HasColumnName("CODCCFECF");

        builder.Property(e => e.CodPedidoVenda).HasColumnName("CODPEDIDOVENDA");

        builder.Property(e => e.EspeciePagamento).HasColumnName("ESPECIEPAGAMENTO");

        builder.Property(e => e.InformacaoFiscal).HasColumnName("INFORMACAOFISCAL");

        builder.Property(e => e.IDEstrangeiro).HasColumnName("IDESTRANGEIRO");

        builder.Property(e => e.Status).HasColumnName("STATUS");

        builder.Property(e => e.ModoFrete).HasColumnName("MODOFRETE");

        builder.Property(e => e.AVista).HasColumnName("AVISTA");

        builder.Property(e => e.JAFaturada).HasColumnName("JAFATURADA");

        builder.Property(e => e.SequenciaCCE).HasColumnName("SEQUENCIACCE");

        builder.Property(e => e.CodigoStatusCancelamento).HasColumnName("CODIGOSTATUSCANCELAMENTO");

        builder.Property(e => e.DataHoraCancelamento).HasColumnName("DATAEHORACANCELAMENTO");

        builder.Property(e => e.ProtocoloCancelamento).HasColumnName("PROTOCOLOCANCELAMENTO");

        builder.Property(e => e.Justificativa).HasColumnName("JUSTIFICATIVA");

        builder.Property(e => e.MotivoCancelamento).HasColumnName("MOTIVOCANCELAMENTO");

        builder.Property(e => e.Indicador).HasColumnName("INDICADOR");

        builder.Property(e => e.NumeroNota).HasColumnName("NUMERONOTA");

        builder.Property(e => e.CodProduto).HasColumnName("CODPRODUTO");

        builder.Property(e => e.MD5J1).HasColumnName("MD5J1");

        builder.Property(e => e.ValorTotalFCPST).HasColumnName("VALORTOTALFCPST");

        builder.Property(e => e.IndConsumidorFinal).HasColumnName("INDCONSUMIDORFINAL");

        builder.Property(e => e.CodNotaManual).HasColumnName("CODNOTAMANUAL");

        builder.Property(e => e.Verificado).HasColumnName("VERIFICADO");

        builder.Property(e => e.CNAE).HasColumnName("CNAE");

        builder.Property(e => e.CNF).HasColumnName("CNF");

        builder.Property(e => e.NumeroCompra).HasColumnName("NUMEROCOMPRA");
    }
}

