using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using static Fiscal.Classe.DataContext;
using Fiscal.Classe;

namespace Fiscal
{

    public partial class SpedFiscal : Form
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

        public SpedFiscal()
        {
            InitializeComponent();

        }

        public void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Registro000 registro000 = new Registro000();

            registro000.spedFiscal = this;
            registro000.BlocosSped(registro000.GetSpedFiscal());
        }

        private void DataTimeIni_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataInicial = DataTimeIni.Value;

            int ultimoDiaDoMes = DateTime.DaysInMonth(dataInicial.Year, dataInicial.Month);
            DateTime dataFinal = new DateTime(dataInicial.Year, dataInicial.Month, ultimoDiaDoMes);

            DataTimeFin.Value = dataFinal;
        }
    }
}
