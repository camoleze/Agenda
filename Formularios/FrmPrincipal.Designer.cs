namespace Agenda.Formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpPrincipal = new System.Windows.Forms.TabPage();
            this.gpbPessoa = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbFone = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.tbpEmpresa = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tbpPrincipal.SuspendLayout();
            this.gpbPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpPrincipal);
            this.tabControl1.Controls.Add(this.tbpEmpresa);
            this.tabControl1.Location = new System.Drawing.Point(11, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 255);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpPrincipal
            // 
            this.tbpPrincipal.Controls.Add(this.gpbPessoa);
            this.tbpPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tbpPrincipal.Name = "tbpPrincipal";
            this.tbpPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPrincipal.Size = new System.Drawing.Size(435, 229);
            this.tbpPrincipal.TabIndex = 0;
            this.tbpPrincipal.Text = "Pessoa";
            this.tbpPrincipal.UseVisualStyleBackColor = true;
            // 
            // gpbPessoa
            // 
            this.gpbPessoa.Controls.Add(this.btnLimpar);
            this.gpbPessoa.Controls.Add(this.btnAlterar);
            this.gpbPessoa.Controls.Add(this.btnCadastrar);
            this.gpbPessoa.Controls.Add(this.mtbCelular);
            this.gpbPessoa.Controls.Add(this.mtbFone);
            this.gpbPessoa.Controls.Add(this.txtemail);
            this.gpbPessoa.Controls.Add(this.txtApelido);
            this.gpbPessoa.Controls.Add(this.txtNome);
            this.gpbPessoa.Controls.Add(this.label5);
            this.gpbPessoa.Controls.Add(this.label4);
            this.gpbPessoa.Controls.Add(this.label3);
            this.gpbPessoa.Controls.Add(this.lblApelido);
            this.gpbPessoa.Controls.Add(this.lblnome);
            this.gpbPessoa.Location = new System.Drawing.Point(7, 7);
            this.gpbPessoa.Name = "gpbPessoa";
            this.gpbPessoa.Size = new System.Drawing.Size(217, 216);
            this.gpbPessoa.TabIndex = 0;
            this.gpbPessoa.TabStop = false;
            this.gpbPessoa.Text = "Cadastro/Pesquisa";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(168, 180);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(43, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(66, 180);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(46, 23);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(7, 180);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(53, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mtbCelular
            // 
            this.mtbCelular.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mtbCelular.Location = new System.Drawing.Point(53, 124);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(85, 20);
            this.mtbCelular.TabIndex = 11;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // mtbFone
            // 
            this.mtbFone.Location = new System.Drawing.Point(51, 97);
            this.mtbFone.Mask = "(99) 0000-0000";
            this.mtbFone.Name = "mtbFone";
            this.mtbFone.Size = new System.Drawing.Size(87, 20);
            this.mtbFone.TabIndex = 10;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(51, 149);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(160, 20);
            this.txtemail.TabIndex = 9;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(51, 61);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(160, 20);
            this.txtApelido.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(39, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(172, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fone :";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(3, 64);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(48, 13);
            this.lblApelido.TabIndex = 1;
            this.lblApelido.Text = "Apelido :";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(4, 33);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // tbpEmpresa
            // 
            this.tbpEmpresa.Location = new System.Drawing.Point(4, 22);
            this.tbpEmpresa.Name = "tbpEmpresa";
            this.tbpEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEmpresa.Size = new System.Drawing.Size(435, 229);
            this.tbpEmpresa.TabIndex = 1;
            this.tbpEmpresa.Text = "Empresa";
            this.tbpEmpresa.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 282);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpPrincipal.ResumeLayout(false);
            this.gpbPessoa.ResumeLayout(false);
            this.gpbPessoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpPrincipal;
        private System.Windows.Forms.GroupBox gpbPessoa;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.MaskedTextBox mtbFone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TabPage tbpEmpresa;
        private System.Windows.Forms.Button btnLimpar;
    }
}