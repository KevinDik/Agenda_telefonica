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
        int indice;
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
            listboxEdit.Items.Clear();

            foreach (Cl_Contato item in Cl_Geral.Lista_contatos)
            {
                listboxEdit.Items.Add(item.nome + " (" + item.contato + ")");
            }

            lbl_registros.Text = "Registros: " + listboxEdit.Items.Count;

            //impedir edicao e eliminacao 
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;
        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            //insere um novo registro na lista
            if (txt_nome.Text == "" || txt_numero.Text == "")
            {
                MessageBox.Show("Os campos não estão corretamente preenchidos");
                return;
            }

            //verifica se existe regitro igual na lista
            foreach(Cl_Contato item in Cl_Geral.Lista_contatos)
            {
                if(item.nome == txt_nome.Text && item.contato == txt_numero.Text)
                {
                    MessageBox.Show("ERRO! Este registro já existe");
                    return;
                }
            }

            Cl_Geral.Gravar_novo_registro(txt_nome.Text, txt_numero.Text);

            //atualiza lista
            Adiciona_lista();

            //prepara novo resgistro
            txt_nome.Text = "";
            txt_numero.Text = "";
            txt_nome.Focus();

        }

        private void frmInserir_editar_Load(object sender, EventArgs e)
        {

        }

        private void listboxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selecionar um contato
            if (listboxEdit.SelectedIndex == -1) return;

            indice = listboxEdit.SelectedIndex;
            cmd_apagar.Enabled = true;
            cmd_editar.Enabled = true;
        }

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            //apaga o registro
            Cl_Geral.Lista_contatos.RemoveAt(indice);
            Cl_Geral.Gravar_ficheiro();
            Adiciona_lista();
        }
    }
}
