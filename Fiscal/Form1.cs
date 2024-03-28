using FirebirdSql.EntityFrameworkCore;
using System.Runtime.InteropServices;



namespace Fiscal
{


    public partial class Form1 : Form
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


        public Form1()
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

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            Configurações configurações = new Configurações();
            configurações.ShowDialog();
        }
    }
}
