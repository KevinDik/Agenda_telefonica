namespace Agenda_telefonica
{
    partial class frm_resultados
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
            this.cmd_novaPesquisa = new System.Windows.Forms.Button();
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.list_resultados = new System.Windows.Forms.ListBox();
            this.lbl_registros2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_novaPesquisa
            // 
            this.cmd_novaPesquisa.Location = new System.Drawing.Point(131, 275);
            this.cmd_novaPesquisa.Name = "cmd_novaPesquisa";
            this.cmd_novaPesquisa.Size = new System.Drawing.Size(89, 23);
            this.cmd_novaPesquisa.TabIndex = 0;
            this.cmd_novaPesquisa.Text = "Nova pesquisa";
            this.cmd_novaPesquisa.UseVisualStyleBackColor = true;
            this.cmd_novaPesquisa.Click += new System.EventHandler(this.cmd_novaPesquisa_Click);
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(226, 275);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(75, 23);
            this.cmd_fechar.TabIndex = 1;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // list_resultados
            // 
            this.list_resultados.FormattingEnabled = true;
            this.list_resultados.Location = new System.Drawing.Point(40, 5);
            this.list_resultados.Name = "list_resultados";
            this.list_resultados.Size = new System.Drawing.Size(220, 264);
            this.list_resultados.TabIndex = 2;
            // 
            // lbl_registros2
            // 
            this.lbl_registros2.AutoSize = true;
            this.lbl_registros2.Location = new System.Drawing.Point(37, 280);
            this.lbl_registros2.Name = "lbl_registros2";
            this.lbl_registros2.Size = new System.Drawing.Size(43, 13);
            this.lbl_registros2.TabIndex = 9;
            this.lbl_registros2.Text = "Total: 0";
            // 
            // frm_resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 310);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_registros2);
            this.Controls.Add(this.list_resultados);
            this.Controls.Add(this.cmd_fechar);
            this.Controls.Add(this.cmd_novaPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.frm_resultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_novaPesquisa;
        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.ListBox list_resultados;
        private System.Windows.Forms.Label lbl_registros2;
    }
}