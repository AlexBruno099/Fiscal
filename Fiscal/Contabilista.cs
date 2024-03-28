using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Fiscal.Classe;
using static Fiscal.Classe.DataContext;

namespace Fiscal
{
    public partial class Contabilista : Form
    {

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwn, int attr, int[] attrValue, int attriSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
            {
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
        }

        public Contabilista()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Contabilista_Load(object sender, EventArgs e)
        {
            using (var dc = new Contexto())
            { 
                var dados = dc.dadoContabilistas.FirstOrDefault();
                NomeContText.Text = dados.Nome;
                CnpjText.Text = dados.CNPJ;
                CrcText.Text = dados.CRC;
                CepText.Text = dados.CEP;
                CpfText.Text = dados.CPF;
                EnderecoText.Text = dados.Endereco;
                NumeroText.Text = dados.Numero;
                ComplementoText.Text = dados.Complemento;
                BairroText.Text = dados.Bairro;
                TellText.Text = dados.Telefone;
                FaxText.Text = dados.FAX;
                EmailText.Text = dados.Email;
                CodIbgeText.Text = dados.CodMunicipio;
                CodContAnaText.Text = dados.CodContaAnalitica;
            }
        }
    }
}
