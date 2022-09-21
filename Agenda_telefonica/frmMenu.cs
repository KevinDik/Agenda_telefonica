using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_telefonica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //apresenta versão do software
            label2.Text = Cl_Geral.versao;

            //carrega os contatos
            Cl_Geral.Constroe_lista_contatos();
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void cmd_inserir_Click(object sender, EventArgs e)
        {
            //abre lista de contatos
            frmInserir_editar formulario = new frmInserir_editar();
            formulario.ShowDialog();
        }
    }
}
