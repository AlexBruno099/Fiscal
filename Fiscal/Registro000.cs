using Fiscal.Classe;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
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
        public void BlocosSped()
        {
            using (var context = new DataContext.Contexto())
            {
                IQueryable<Emitente> emit = context.emitente;

                var teste = emit.AsQueryable().First();

                string registro00;

                registro00 = "teste||" + teste.RazaoSocial + "||";
                registro00 += "alek||" + teste.RazaoSocial + Environment.NewLine;
                




                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Arquivo de testo (*.txt)|.txt";
            saveFileDialog1.Title = "Salvar Arquivo SPED";
            saveFileDialog1.FileName = "SPED" + DateTime.Now.ToString("yyyyMMdd");
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            if (saveFileDialog1.ShowDialog() == DialogResult.OK) ;
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
        }
        }
    }
}


