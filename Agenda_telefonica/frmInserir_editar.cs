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
    public partial class frmInserir_editar : Form
    {
        public frmInserir_editar()
        {
            InitializeComponent();
            Adiciona_lista();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adiciona_lista() 
        {
            listbox_agenda.Items.Clear();

            foreach (Cl_Contato item in Cl_Geral.Lista_contatos)
            {
                listbox_agenda.Items.Add(item.nome + " (" + item.contato + ")");
            }
        }
    }
}
