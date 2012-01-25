namespace Localizador
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupCep = new System.Windows.Forms.GroupBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIPUF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIPCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mtxtIP = new System.Windows.Forms.MaskedTextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIPPais = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIPLocal = new System.Windows.Forms.Button();
            this.groupCep.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCep
            // 
            this.groupCep.Controls.Add(this.txtUF);
            this.groupCep.Controls.Add(this.label2);
            this.groupCep.Controls.Add(this.txtCidade);
            this.groupCep.Controls.Add(this.label1);
            this.groupCep.Controls.Add(this.txtBairro);
            this.groupCep.Controls.Add(this.lblBairro);
            this.groupCep.Controls.Add(this.txtEndereco);
            this.groupCep.Controls.Add(this.lblEndereco);
            this.groupCep.Controls.Add(this.btnBuscar);
            this.groupCep.Controls.Add(this.mtxtCEP);
            this.groupCep.Controls.Add(this.lblCEP);
            this.groupCep.Location = new System.Drawing.Point(12, 12);
            this.groupCep.Name = "groupCep";
            this.groupCep.Size = new System.Drawing.Size(510, 151);
            this.groupCep.TabIndex = 0;
            this.groupCep.TabStop = false;
            this.groupCep.Text = "CEP";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(6, 27);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(87, 13);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "Digite o seu CEP";
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Location = new System.Drawing.Point(99, 26);
            this.mtxtCEP.Mask = "00,000-000";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(97, 20);
            this.mtxtCEP.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(202, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(7, 65);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(65, 61);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(419, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(7, 103);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(65, 99);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(162, 20);
            this.txtBairro.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(275, 99);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(112, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estado";
            // 
            // txtUF
            // 
            this.txtUF.Enabled = false;
            this.txtUF.Location = new System.Drawing.Point(447, 99);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(37, 20);
            this.txtUF.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIPLocal);
            this.groupBox1.Controls.Add(this.txtIPPais);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIPUF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIPCidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mtxtIP);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 151);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP";
            // 
            // txtIPUF
            // 
            this.txtIPUF.Enabled = false;
            this.txtIPUF.Location = new System.Drawing.Point(217, 71);
            this.txtIPUF.Name = "txtIPUF";
            this.txtIPUF.Size = new System.Drawing.Size(37, 20);
            this.txtIPUF.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado";
            // 
            // txtIPCidade
            // 
            this.txtIPCidade.Enabled = false;
            this.txtIPCidade.Location = new System.Drawing.Point(50, 71);
            this.txtIPCidade.Name = "txtIPCidade";
            this.txtIPCidade.Size = new System.Drawing.Size(112, 20);
            this.txtIPCidade.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cidade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtxtIP
            // 
            this.mtxtIP.Location = new System.Drawing.Point(99, 26);
            this.mtxtIP.Name = "mtxtIP";
            this.mtxtIP.Size = new System.Drawing.Size(97, 20);
            this.mtxtIP.TabIndex = 2;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(6, 27);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(80, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "Pesquise um IP";
            // 
            // txtIPPais
            // 
            this.txtIPPais.Enabled = false;
            this.txtIPPais.Location = new System.Drawing.Point(302, 71);
            this.txtIPPais.Name = "txtIPPais";
            this.txtIPPais.Size = new System.Drawing.Size(185, 20);
            this.txtIPPais.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "País";
            // 
            // btnIPLocal
            // 
            this.btnIPLocal.Location = new System.Drawing.Point(284, 23);
            this.btnIPLocal.Name = "btnIPLocal";
            this.btnIPLocal.Size = new System.Drawing.Size(113, 23);
            this.btnIPLocal.TabIndex = 8;
            this.btnIPLocal.Text = "Buscar meu local";
            this.btnIPLocal.UseVisualStyleBackColor = true;
            this.btnIPLocal.Click += new System.EventHandler(this.btnIPLocal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupCep);
            this.Name = "Form1";
            this.Text = "Localizador";
            this.groupCep.ResumeLayout(false);
            this.groupCep.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCep;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIPUF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIPCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtxtIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIPPais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIPLocal;
    }
}

