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

namespace Fiscal
{
    public class Registro000
    {
        public SpedFiscal spedFiscal;
        public void BlocosSped()
        {

            using (var context = new DataContext.Contexto())
            {
                DateTime dataInicial = spedFiscal.DataTimeIni.Value;
                DateTime dataFinal = spedFiscal.DataTimeFin.Value;

                IQueryable<Emitente> emit = context.emitente;
                IQueryable<Fornecedor> fornecedor = context.fornecedor;
                IQueryable<Cliente> cliente = context.cliente;
                IQueryable<Compra> compra = context.Compra;
                IQueryable<Estoque> estoque = context.Estoque;
                IQueryable<TVendaNFCe> tvendaNfce = context.TVendaNFCe;
                IQueryable<TVendaNFe> tvendaNFe = context.TVendaNFe;


                var DadosCont = context.dadoContabilistas.FirstOrDefault();
                var DadosEmit = emit.AsQueryable().First();
                var DadosForn = fornecedor.AsQueryable().FirstOrDefault();
                var DadosCli = cliente.AsQueryable().FirstOrDefault();
                var compras = compra.ToList().Where(comp => (comp.DataRecebimento >= dataInicial && comp.DataRecebimento <= dataFinal));
                var DadosEst = estoque.ToList();
                var DadosVendNfc = tvendaNfce.ToList().Where(vendnfce => (vendnfce.DataEmissao >= dataInicial && vendnfce.DataEmissao <= dataFinal));
                var DadosVendaNF = tvendaNFe.ToList().Where(vendnfe => (vendnfe.DataEmissao >= dataInicial && vendnfe.DataEmissao <= dataFinal));

                string CNPJSemMascEmit = DadosEmit.CNPJ.Replace(".", "").Replace("/", "").Replace("-", "");
                string TelefoneSemMascEmit = DadosEmit.Telefone.Replace(".", "").Replace("/", "").Replace("-", "");
                string FaxSemMascEmit = DadosEmit.FAX.Replace(".", "").Replace("/", "").Replace("-", "");
                string TelefoneSemMasc = DadosCont.Telefone.Replace(".", "").Replace("/", "").Replace("-", "");
                string CNPJSemMascClie = DadosCli.CNPJ.Replace(".", "").Replace("/", "").Replace("-", "");
                

                #region 0000

                string registro00;

                registro00 = "|0000|";

                registro00 += spedFiscal.textLeiaute.Text + "|";

                if (spedFiscal.ArqOrig.Checked)
                {
                    registro00 += "0" + "|";
                }
                else if (spedFiscal.ArqSubs.Checked)
                {
                    registro00 += "1" + "|";
                }
                registro00 += dataInicial + "|" + dataFinal + "|";
                registro00 += DadosEmit.RazaoSocial + "|";
                registro00 += CNPJSemMascEmit + "|";
                registro00 += DadosEmit.UF + "|";
                registro00 += DadosEmit.IE + "|";
                registro00 += DadosEmit.Suframa + "|";

                if (spedFiscal.btnPerfA.Checked)
                {
                    registro00 += "A";
                }

                else if (spedFiscal.btnPerfB.Checked)
                {
                    registro00 += "B";
                }

                else if (spedFiscal.btnPerfC.Checked)
                {
                    registro00 += "C";
                }

                registro00 += "|1|" + Environment.NewLine;


                registro00 += "|0001|" + "0|" + Environment.NewLine;
                #endregion

                #region 0005
                registro00 += "|0005|" + DadosEmit.NomeFantasia + "|";
                registro00 += DadosEmit.CEP + "|";
                registro00 += DadosEmit.Endereco + "|";
                registro00 += DadosEmit.Numero + "|";
                registro00 += DadosEmit.Complemento + "|";
                registro00 += DadosEmit.Bairro + "|";
                registro00 += TelefoneSemMascEmit + "|";
                registro00 += FaxSemMascEmit + "|" + Environment.NewLine;
                #endregion

                #region 0100
                registro00 += "|0100|" + DadosCont.Nome + "|";
                registro00 += DadosCont.CPF + "|";
                registro00 += DadosCont.CRC + "|";
                registro00 += DadosCont.CEP + "|";
                registro00 += DadosCont.Endereco + "|";
                registro00 += DadosCont.Numero + "|";
                registro00 += DadosCont.Complemento + "|";
                registro00 += DadosCont.Bairro + "|";
                registro00 += TelefoneSemMasc + "|";
                registro00 += DadosCont.FAX + "|";
                registro00 += DadosCont.Email + "|";
                registro00 += DadosCont.CodMunicipio + "|" + Environment.NewLine;
                #endregion

                #region 0150 Fornecedor
                registro00 += "|0150|";
                registro00 += DadosForn.Controle + "|";
                registro00 += DadosForn.NomeFantasia + "|";
                registro00 += DadosForn.CodigoPais + "|";
                registro00 += DadosForn.CNPJ + "|";
                registro00 += DadosForn.CPF + "|";
                registro00 += DadosForn.IE + "|";
                registro00 += DadosForn.CodigoCidadeIBGE + "|";
                registro00 += DadosForn.Suframa + "|";
                registro00 += DadosForn.Endereco + "|";
                registro00 += DadosForn.Numero + "|";
                registro00 += DadosForn.Complemento + "|";
                registro00 += DadosForn.Bairro + "|" + Environment.NewLine;
                #endregion

                #region 0150 Cliente
                registro00 += "|0150|";
                registro00 += DadosCli.Controle + "|";
                registro00 += DadosCli.NomeCliente + "|";
                registro00 += DadosCli.CodigoPais + "|";
                registro00 += CNPJSemMascClie + "|";
                registro00 += DadosCli.CPF + "|";
                registro00 += DadosCli.IE + "|";
                registro00 += DadosCli.CodigoCidadeIBGE + "|";
                registro00 += DadosCli.Suframa + "|";
                registro00 += DadosCli.Endereco + "|";
                registro00 += DadosCli.Numero + "|";
                registro00 += DadosCli.Complemento + "|";
                registro00 += DadosCli.Bairro + "|" + Environment.NewLine;
                #endregion

                #region Select forn
                var Select = compras.Join(fornecedor, comp => comp.CodFornecedor, forn => forn.Controle, (comp, forn) => new
                {
                    comp.DataRecebimento,
                    forn.Controle,
                    forn.RazaoSocial,
                    forn.CodigoPais,
                    forn.CNPJ,
                    forn.CPF,
                    forn.IE,
                    forn.CodigoCidadeIBGE,
                    forn.Suframa,
                    forn.Endereco,
                    forn.Numero,
                    forn.Complemento,
                    forn.Bairro,
                    comp.Confirmada
                });


                foreach (var comp in compras)
                {
                    var fornecedore = context.fornecedor.Where(c => c.Controle == comp.CodFornecedor).FirstOrDefault();

                    registro00 += "|0150|";
                    registro00 += fornecedore.Controle + "|";
                    registro00 += fornecedore.RazaoSocial + "|";
                    registro00 += fornecedore.CodigoPais + "|";
                    registro00 += fornecedore.CNPJ + "|";
                    registro00 += fornecedore.CPF + "|";
                    registro00 += fornecedore.IE + "|";
                    registro00 += fornecedore.CodigoCidadeIBGE + "|";
                    registro00 += fornecedore.Suframa + "|";
                    registro00 += fornecedore.Endereco + "|";
                    registro00 += fornecedore.Numero + "|";
                    registro00 += fornecedore.Complemento + "|";
                    registro00 += fornecedore.Bairro + "|" + Environment.NewLine;
                }
                #endregion

                #region Select cliente vendanfe
                var SelectClieNF = DadosVendaNF.Join(cliente, vendnfe => vendnfe.CodCliente, cliente => cliente.Controle, (vendnfe, cliente) => new
                {
                    vendnfe.DataEmissao,
                    cliente.Controle,
                    cliente.NomeCliente,
                    cliente.CodigoPais,
                    cliente.CNPJ,
                    cliente.CPF,
                    cliente.IE,
                    cliente.CodigoCidadeIBGE,
                    cliente.Suframa,
                    cliente.Endereco,
                    cliente.Numero,
                    cliente.Complemento,
                    cliente.Bairro,
                    vendnfe.StatusEnvio
                });

                var distincSelectClieNF = SelectClieNF.GroupBy(e => new
                {
                    e.Controle,
                    e.NomeCliente,
                    e.CodigoPais,
                    e.CNPJ,
                    e.CPF,
                    e.IE,
                    e.CodigoCidadeIBGE,
                    e.Suframa,
                    e.Endereco,
                    e.Numero,
                    e.Complemento,
                    e.Bairro
                }).Select(group => group.FirstOrDefault());

                foreach (var vendanfe in distincSelectClieNF)
                {

                    registro00 += "|0150|";
                    registro00 += vendanfe.Controle + "|";
                    registro00 += vendanfe.NomeCliente + "|";
                    registro00 += vendanfe.CodigoPais + "|";
                    registro00 += vendanfe.CNPJ + "|";
                    registro00 += vendanfe.CPF + "|";
                    registro00 += vendanfe.IE + "|";
                    registro00 += vendanfe.CodigoCidadeIBGE + "|";
                    registro00 += vendanfe.Suframa + "|";
                    registro00 += vendanfe.Endereco + "|";
                    registro00 += vendanfe.Numero + "|";
                    registro00 += vendanfe.Complemento + "|";
                    registro00 += vendanfe.Bairro + "|" + Environment.NewLine;
                }



                #endregion

                #region Select cliente Nfc

                var SelectClieNFC = DadosVendNfc.Join(cliente, vendnfce => vendnfce.CodigoCliente, cliente => cliente.Controle, (vendnfce, cliente) => new
                {
                    cliente.Controle,
                    cliente.NomeCliente,
                    cliente.CodigoPais,
                    cliente.CNPJ,
                    cliente.CPF,
                    cliente.IE,
                    cliente.CodigoCidadeIBGE,
                    cliente.Suframa,
                    cliente.Endereco,
                    cliente.Numero,
                    cliente.Complemento,
                    cliente.Bairro
                });


                var distinctSelect0150Nfce = SelectClieNFC.GroupBy(e => new
                {
                    e.Controle,
                    e.NomeCliente,
                    e.CodigoPais,
                    e.CNPJ,
                    e.CPF,
                    e.IE,
                    e.CodigoCidadeIBGE,
                    e.Suframa,
                    e.Endereco,
                    e.Numero,
                    e.Complemento,
                    e.Bairro

                }).Select(group => group.First());


                foreach (var vendanfe in distinctSelect0150Nfce)
                {
                    registro00 += "|0150|";
                    registro00 += vendanfe.Controle + "|";
                    registro00 += vendanfe.NomeCliente + "|";
                    registro00 += vendanfe.CodigoPais + "|";
                    registro00 += vendanfe.CNPJ + "|";
                    registro00 += vendanfe.CPF + "|";
                    registro00 += vendanfe.IE + "|";
                    registro00 += vendanfe.CodigoCidadeIBGE + "|";
                    registro00 += vendanfe.Suframa + "|";
                    registro00 += vendanfe.Endereco + "|";
                    registro00 += vendanfe.Numero + "|";
                    registro00 += vendanfe.Complemento + "|";
                    registro00 += vendanfe.Bairro + "|" + Environment.NewLine;
                }

                #endregion

                #region 0200
                foreach (var est in estoque)
                {
                    var DadosEstoq = context.Estoque.Where(c => c.Controle == est.Controle).FirstOrDefault();

                    registro00 += "|0200|";
                    registro00 += DadosEstoq.Controle + "|";
                    registro00 += DadosEstoq.Produto + "|";
                    registro00 += DadosEstoq.CodBarras + "|";
                    registro00 += "|";
                    registro00 += DadosEstoq.UNIDADETRIBUTAVEL + "|";
                    registro00 += DadosEstoq.TipoTributação + "|";
                    registro00 += DadosEstoq.NCM + "|";
                    registro00 += /*EX_IPI*/ "|";
                    registro00 += /*COD_GEN*/ "|";
                    registro00 += /*COD_LST*/ "|";
                    registro00 += DadosEstoq.AliquotaIcmsEcf + "|";
                    registro00 += DadosEstoq.Cest + "|" + Environment.NewLine;
                }
                #endregion

                #region Salvar arquivo
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Arquivo de testo (*.txt)|.txt";
                saveFileDialog1.Title = "Salvar Arquivo SPED";
                saveFileDialog1.FileName = "SPED" + DateTime.Now.ToString("yyyyMMdd");
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = saveFileDialog1.FileName;
                    try
                    {

                        File.WriteAllText(caminhoArquivo, registro00);

                        MessageBox.Show("SPED gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao gerar o arquivo SPED:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                #endregion 

            }
        }
    }
}


