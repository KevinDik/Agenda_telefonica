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
    public partial class frm_resultados : Form
    {
        string texto;
        public frm_resultados(string texto)
        {
            InitializeComponent();

            //definir o texto de pesquisa
            this.texto = texto.ToUpper();
        }

        private void frm_resultados_Load(object sender, EventArgs e)
        {
            //executa a pesquisa e controe a lista
            ExecutaPesquisa();
        }

        private void ExecutaPesquisa()
        {
            //realiza a pesquisa e apresenta dados
            List<Cl_Contato> lista_resultados = new List<Cl_Contato>();
            foreach (Cl_Contato contato in Cl_Geral.Lista_contatos)
            {
                if(contato.nome.ToUpper().Contains(texto) || contato.contato.ToUpper().Contains(texto))
                {
                    lista_resultados.Add(contato);
                }
            }
            //apresentar os resultados

            list_resultados.Items.Clear();
            foreach (Cl_Contato contato in lista_resultados)
            {
                list_resultados.Items.Add(contato.nome + " (" + contato.contato + ")");
            }

            lbl_registros2.Text = "Registros: " + list_resultados.Items.Count;

        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //fecha
            this.Close();
        }

        private void cmd_novaPesquisa_Click(object sender, EventArgs e)
        {
            //pedir novo textp
            frm_Texto f = new frm_Texto();
            f.ShowDialog();

            //quando fechar o quadro

            if (f.cancelado) return;
            texto = f.texto.ToUpper();

            ExecutaPesquisa();
        }
    }
}
