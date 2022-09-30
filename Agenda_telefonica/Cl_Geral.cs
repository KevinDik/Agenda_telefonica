using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Agenda_telefonica
{
    public static class Cl_Geral
    {
        public static string versao = "v 1.0.0";

        //estrutura generica dos contatos

        public static List<Cl_Contato> Lista_contatos;

        public static void Constroe_lista_contatos()
        {
            //metodo que carrega a lista de contatos
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string ficheiro = pasta_documentos + @"\telefonica.txt";

            //cria lista vazia
            Lista_contatos = new List<Cl_Contato>();

            if (File.Exists(ficheiro))
            {
                StreamReader file = new StreamReader(ficheiro, Encoding.Default);

                //carregar os contatos 
                while (!file.EndOfStream)
                {
                    //carrega dados
                    string nome = file.ReadLine();
                    string contato = file.ReadLine();

                    //adicionar o contato carregado
                    Cl_Contato novo_contato = new Cl_Contato();
                    novo_contato.nome = nome;
                    novo_contato.contato = contato;

                    //adicionar a lista
                    Lista_contatos.Add(novo_contato);
                }

                file.Dispose();
            }
        }

        public static void Gravar_novo_registro(string nome, string contato)
        {
            //gravar um novo registro na lista e ficheiro

            Lista_contatos.Add(new Cl_Contato() { nome = nome, contato = contato });
            Gravar_ficheiro();
            
        }

        public static void Gravar_ficheiro()
        {
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string telefonica = pasta_documentos + @"\telefonica.txt";

            StreamWriter ficheiro = new StreamWriter(telefonica, false, Encoding.Default);
            foreach (Cl_Contato item in Lista_contatos)
            {
                ficheiro.WriteLine(item.nome);
                ficheiro.WriteLine(item.contato);
            }
            ficheiro.Dispose();
        }
    }
}
