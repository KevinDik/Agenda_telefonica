namespace Agenda_telefonica
{
    partial class frmInserir_editar
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
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.cmd_gravar = new System.Windows.Forms.Button();
            this.listboxEdit = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_registros = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(303, 263);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(95, 23);
            this.cmd_fechar.TabIndex = 6;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(43, 15);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(84, 12);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(288, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(84, 38);
            this.txt_numero.MaxLength = 11;
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(120, 20);
            this.txt_numero.TabIndex = 2;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(43, 41);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 3;
            this.lbl_numero.Text = "Numero";
            // 
            // cmd_gravar
            // 
            this.cmd_gravar.Location = new System.Drawing.Point(303, 90);
            this.cmd_gravar.Name = "cmd_gravar";
            this.cmd_gravar.Size = new System.Drawing.Size(95, 23);
            this.cmd_gravar.TabIndex = 3;
            this.cmd_gravar.Text = "Gravar";
            this.cmd_gravar.UseVisualStyleBackColor = true;
            this.cmd_gravar.Click += new System.EventHandler(this.cmd_gravar_Click);
            // 
            // listboxEdit
            // 
            this.listboxEdit.FormattingEnabled = true;
            this.listboxEdit.Location = new System.Drawing.Point(12, 90);
            this.listboxEdit.Name = "listboxEdit";
            this.listboxEdit.Size = new System.Drawing.Size(271, 186);
            this.listboxEdit.TabIndex = 6;
            this.listboxEdit.SelectedIndexChanged += new System.EventHandler(this.listboxEdit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contatos Salvos";
            // 
            // lbl_registros
            // 
            this.lbl_registros.AutoSize = true;
            this.lbl_registros.Location = new System.Drawing.Point(9, 279);
            this.lbl_registros.Name = "lbl_registros";
            this.lbl_registros.Size = new System.Drawing.Size(43, 13);
            this.lbl_registros.TabIndex = 8;
            this.lbl_registros.Text = "Total: 0";
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Location = new System.Drawing.Point(303, 148);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(95, 23);
            this.cmd_apagar.TabIndex = 5;
            this.cmd_apagar.Text = "Apagar contato";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.Location = new System.Drawing.Point(303, 119);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(95, 23);
            this.cmd_editar.TabIndex = 4;
            this.cmd_editar.Text = "Editar contato";
            this.cmd_editar.UseVisualStyleBackColor = true;
            // 
            // frmInserir_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 298);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.lbl_registros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxEdit);
            this.Controls.Add(this.cmd_gravar);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInserir_editar";
            this.Text = "Inserir / Editar";
            this.Load += new System.EventHandler(this.frmInserir_editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.ListBox listboxEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_registros;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
    }
}