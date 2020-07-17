using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.IO;
using System.Collections;
namespace Projeto_TCM_3
{
    public class Utils
    {
        /// <summary>
        /// Esta classe, tem como objetivo, armazenar métodos que serão muito úteis ao longo de todo o projeto, para que seja evitado ao máximo códigos repetidos;
        /// Para serem utilizados, primeiramene deve-se declarar a classe Utils;
        /// Modelo de declaração: Utils utl = new Utils();
        /// Exemplo de Uso: utl.Mensagem("Um diálogo");
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CadastroPedidos());
        }

        //Métodos variados---------------------------------------------------------------------------------------------
        //Este método é responsável por exibir caixas de diálogos, de diferentes tipos=======================
        public String[] msg = { "Deseja mesmo cancelar o cadastro? Esta ação não poderá ser desfeita", "Deseja mesmo finalizar o cadastro?", 
                                "Deseja mesmo deletar este cadastro? Esta ação não poderá ser desfeita.", "Deseja mesmo alterar este cadastro?", 
                                "Dados incorretos ou incompletos.", "Cadastro não encontrado", "Deseja mesmo sair? O cadastro não finalizado será cancelado.",
                                "Item já existente"};
        public int Mensagem(string msg, int tipo = 0, int pronto = -1)
        {
            if (tipo == 0)
            {
                //Diálogo simples. Exemplo de Uso: utl.Mensagem("Um simples diálogo");
                DialogoSimples Dialg = new DialogoSimples();
                Dialg.mensagem = msg;
                Dialg.StartPosition = FormStartPosition.CenterScreen;
                Dialg.ShowDialog();
                
                return -1;
            }
            else if (tipo == 1)
            {
                //Diálogo com opção de escolha, retornando a resposta do usuário (0 - Sim; 1 - Não.). Exemplo de Uso: utl.Mensagem("Deseja mesmo sair?", 1);
                DialogoEscolha DialgE = new DialogoEscolha();
                DialgE.mensagem = msg;
                DialgE.StartPosition = FormStartPosition.CenterScreen;
                DialgE.ShowDialog();
                return DialgE.escolha;
            }
            else return -1;
        }
        //===================================================================================================

        //-------------------------------------------------------------------------------------------------------------

        //Métodos de Manipulação de Banco de Dados SQL/Access----------------------------------------------------------
        public String Diretorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Rose Doces");
        public String Arquivo = "\\RoseDoces.mdb";

        //Este método é responsável por verificar e inserir o arquivo de Banco de Dados no sistema===========
        public void VerBancoDados(int func = 0)
        {
            //Verifica se o Banco de Dados está no sistema, caso contrário ele é criado
            if (func == 0)
            {
                if (!Directory.Exists(Diretorio))
                {
                    Directory.CreateDirectory(Diretorio);
                    //Mensagem("Diretório não encontrado.\nCriando. . ."); //Somente ser usado nos Testes

                    if (!System.IO.File.Exists(Diretorio))
                    {
                        //Mensagem("Banco de Dados não encontrado.\nCriando. . ."); //Somente ser usado nos Testes
                        File.WriteAllBytes(Diretorio + "\\RoseDoces.mdb", Properties.Resources.RoseDoces);
                    }
                }
            }
            else
            {
                File.WriteAllBytes(Diretorio + "\\RoseDoces.mdb", Properties.Resources.RoseDoces);
            }
        }
        //===================================================================================================

        //Este método consulta os dados de um Banco de Dados e os retorna para um DataGridView===============
        public DataTable Consulta(string SQL) 
        {
            try 
            {
                String StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Diretorio + Arquivo;
                OleDbConnection Conn = new OleDbConnection(StringCon);
                Conn.Open();
                OleDbCommand cmd = new OleDbCommand(SQL, Conn);
                OleDbDataAdapter objAdp = new OleDbDataAdapter(cmd);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                return dtLista;

            }
            catch (Exception erro)
            {
                Mensagem(erro.Message);
                return null;
            }
        }
        //===================================================================================================

        //Este método é responsável por fazer a manipulação e conexão com o Banco de Dados===================
        public string Conexao(string SQL, int func = 1, int atrib = 0)
        {
            try
            {
                String StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Diretorio + Arquivo;
                OleDbConnection Conn = new OleDbConnection(StringCon);
                Conn.Open();
                OleDbCommand cmd = new OleDbCommand(SQL, Conn);
                if (func == 1) //Adicionar Dados
                {
                    cmd.ExecuteNonQuery();

                    Conn.Close();
                    if (atrib == 0)
                        Mensagem("Operação concluida com êxito");
                    return null;
                }
                else if (func == 2) //Consultar Dados
                {
                    String[] dados = new String[4];
                    cmd.CommandType = System.Data.CommandType.Text;

                    OleDbDataReader dr;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    dados[0] = dr.GetString(0);
                    dados[1] = dr.GetString(1);
                    dados[2] = dr.GetString(2);
                    dados[3] = dr.GetString(3);
                    return String.Join("&", dados);
                }

                else if (func == 3) //Carrega os dados
                {
                    return null;
                }

                else if (func == 4) //Outra forma de Consultar os Dados (Em testes)
                {
                    OleDbDataReader myReader;
                    ArrayList Itens = new ArrayList();

                    myReader = cmd.ExecuteReader();
                    string sNome = "";
                    while (myReader.Read())
                    {
                        sNome = myReader["Produto"].ToString();
                        Itens.Add(sNome);
                    }
                    return String.Join("&", Itens.ToArray());
                }
                     
                else if (func == 5) //Consultar Dados Individualmente
                {
                    string dados;
                    cmd.CommandType = System.Data.CommandType.Text;

                    OleDbDataReader dr;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    dados = dr[0].ToString();
                    return dados;
                }

                else if (func == 6) //Consultar Dados Individualmente de acordo com o atributo
                {
                    string dados;
                    cmd.CommandType = System.Data.CommandType.Text;

                    OleDbDataReader dr;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    dados = dr[atrib].ToString();
                    return dados;
                }




                else return null;
            }
            catch (Exception erro)
            {
                if (atrib == 0)
                    Mensagem(erro.Message);
                return null;
            }
        }
        //===================================================================================================

        //-------------------------------------------------------------------------------------------------------------

        //Métodos de Manipulação de ListBox----------------------------------------------------------------------------
        //Este método tem a função de carregar ites de um Array e jogar em uma lista=========================
        public void ManipListas(ListBox Lista, string entrada = "") 
        {
            int i;
            String[] saida;
            saida = (entrada.Split('&'));
            Lista.Items.Clear();
            Lista.SelectedIndex = -1;
            for (i = 0; i <= saida.Length - 1; )
            {
                Lista.Items.Add(saida[i]);
                i++;
            }
        }
        //===================================================================================================

        //Este método tem a função de carregar ites de um Array e jogar em uma lista=========================
        public void ManipListas(ComboBox Lista, string entrada = "")
        {
            int i;
            String[] saida;
            saida = (entrada.Split('&'));
            Lista.Items.Clear();
            Lista.SelectedIndex = -1;
            for (i = 0; i <= saida.Length - 1; )
            {
                Lista.Items.Add(saida[i]);
                i++;
            }
        }
        //===================================================================================================


        //Este método tem a função de Adicionar, Alterar, Remover e Consultar uma ListBox====================
        public void ManipListas(ListBox Lista, TextBox Sabor, MaskedTextBox Preco, int func, string entrada = "")
        {
            String[] Consulta = new string[2];
            if (func == 1) 
            {
                
                if (Sabor.Text != "" && Preco.Text != "") //Adicionar Item
                {
                    Lista.Items.Add(Sabor.Text + "-" + Preco.Text);
                    Preco.Clear();
                    Sabor.Clear();

                }
                                
            }
            else if (func == 2) //Alterar Item
            {
                if (Lista.SelectedIndex != -1)
                {
                    Lista.Items.RemoveAt(Lista.SelectedIndex);
                    Lista.Items.Add(Sabor.Text + "-" + Preco.Text);
                    Preco.Clear();
                    Sabor.Clear();
                }
            }
            else if (func == 3) //Remover Item
            {
                if (Lista.SelectedIndex != -1)
                {
                    Lista.Items.RemoveAt(Lista.SelectedIndex);
                    Lista.SelectedIndex = -1;
                    Preco.Clear();
                    Sabor.Clear();
                }

            }

            else if (func == 4) //Consultar Lista
            {
                if (Lista.SelectedIndex != -1)
                {
                    Preco.Clear();
                    Sabor.Clear();
                    try
                    {
                        Consulta = (Lista.SelectedItem.ToString()).Split('-');
                        Sabor.Text = Consulta[0];
                        Preco.Text = Consulta[1];
                    }
                    catch (Exception erro)
                    {
                        Sabor.Text = "Nenhum";
                        Preco.Text = "Nenhum";
                    }
                }

            }

        }
        //===================================================================================================

        //-------------------------------------------------------------------------------------------------------------

    }
}
