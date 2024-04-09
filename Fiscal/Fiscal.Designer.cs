namespace Fiscal
{
    partial class Fiscal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiscal));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            BtnContabilista = new Button();
            BtnConfig = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sintegra;
            pictureBox1.Location = new Point(13, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.sped_fiscal;
            pictureBox2.Location = new Point(164, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Contribuições;
            pictureBox3.Location = new Point(327, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(106, 106);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.background;
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Location = new Point(20, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(603, 322);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleção do arquivo a ser gerado";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.LCDPR;
            pictureBox4.Location = new Point(480, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(106, 106);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.background;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(13, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(584, 91);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Status da geração";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(523, 58);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "0.00%";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(125, 151, 179);
            panel2.Location = new Point(52, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(466, 18);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(125, 151, 179);
            panel1.Location = new Point(52, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 18);
            panel1.TabIndex = 0;
            // 
            // BtnContabilista
            // 
            BtnContabilista.BackColor = Color.FromArgb(20, 51, 255);
            BtnContabilista.FlatStyle = FlatStyle.Flat;
            BtnContabilista.ForeColor = SystemColors.ButtonFace;
            BtnContabilista.Location = new Point(20, 344);
            BtnContabilista.Name = "BtnContabilista";
            BtnContabilista.Size = new Size(119, 25);
            BtnContabilista.TabIndex = 5;
            BtnContabilista.Text = "Contabilista ";
            BtnContabilista.UseVisualStyleBackColor = false;
            BtnContabilista.Click += BtnContabilista_Click;
            // 
            // BtnConfig
            // 
            BtnConfig.BackColor = Color.FromArgb(20, 51, 255);
            BtnConfig.FlatStyle = FlatStyle.Flat;
            BtnConfig.ForeColor = SystemColors.ButtonFace;
            BtnConfig.Location = new Point(164, 344);
            BtnConfig.Name = "BtnConfig";
            BtnConfig.Size = new Size(126, 25);
            BtnConfig.TabIndex = 6;
            BtnConfig.Text = "Configurações";
            BtnConfig.UseVisualStyleBackColor = false;
            BtnConfig.Click += BtnConfig_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 51, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(544, 344);
            button3.Name = "button3";
            button3.Size = new Size(79, 23);
            button3.TabIndex = 7;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(642, 379);
            Controls.Add(button3);
            Controls.Add(BtnConfig);
            Controls.Add(BtnContabilista);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fiscal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private Button BtnContabilista;
        private Button BtnConfig;
        private Button button3;
        private GroupBox groupBox2;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Label label1;
    }
}
