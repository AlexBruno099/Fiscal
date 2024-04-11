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
using Fiscal;
using Fiscal.Properties;

namespace Fiscal
{


    public partial class Fiscal : Form
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


        public Fiscal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnContabilista_Click(object sender, EventArgs e)
        {
            Contabilista contabilista = new Contabilista();
            contabilista.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SpedFiscal Fiscal = new SpedFiscal();
            Fiscal.ShowDialog();
        }

        
    }
}
