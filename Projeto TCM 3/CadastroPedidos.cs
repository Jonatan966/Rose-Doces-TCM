using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections;

namespace Projeto_TCM_3
{
    public partial class CadastroPedidos : Form
    {
        public CadastroPedidos()
        {
            Thread t = new Thread(new ThreadStart(LoadForm));
            Random rnd = new Random();
            //Área reservada para o carregamento dos componentes--------------------
            int etapas = 0;
            do
            {
                switch (etapas)
                {
                    case 0:
                        utl.VerBancoDados();
                        etapas++;
                        break;
                    case 1:
                        utl.Conexao("", 3);
                        etapas++;
                        break;

                }
            } while (etapas <= 1);

            //---------------------------------------------------------------------- 
            t.Start();
            Thread.Sleep(rnd.Next(5000, 8000));
            InitializeComponent();
            t.Abort();
            //Itens a serem carregados depois do loading-----------------------------
            try
            {
                addSabores(0);
                etapas++;
                Thread.Sleep(2500);
            }
            catch { etapas++; }

        }
        public void LoadForm()
        {
            Application.Run(new Splash());
        }



        //Bloco de comandos referente a possibilidade de mover o Formulário----------------------------------
        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;

        private void Tela_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                Arrastando = false;
        }

        private void Tela_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                Arrastando = true;
                ArrastarCursor = Cursor.Position;
                ArrastarForm = this.Location;
            }
        }

        private void Tela_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                if (Arrastando == true)
                {
                    Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                    this.Location = Point.Add(ArrastarForm, new Size(diferenca));
                }
            }
        }
        //---------------------------------------------------------------------------------------------------

        //Controles Principais-------------------------------------------------------------------------------
        Utils utl = new Utils();

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (utl.Mensagem(utl.msg[6], 1) == 0)
            {
                this.Close();
            }
            else { }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            cbPagamento.SelectedIndex = 0;
        }

        private void delTudo(int atrib = 0)
        {
            preco[0] = 0;
            preco[1] = 0;
            preco[2] = 0;
            if (atrib == 0)
            {
                ClienteValid = 0;
                txbEnderecoEntrega.Clear();
                txbExtraCobertura.Clear();
                txbExtraMassa.Clear();
                txbExtraRecheio.Clear();
                txbNomeCliente.Clear();
                txbTelefoneCliente.Clear();
                txbTotal.Clear();
                txbPrecoMassa.Clear();
                txbPrecoCobertura.Clear();
                txbPrecoRecheio.Clear();
                txbUnidades.Value = 0;
                txbCPF.Clear();
                //txbCodigoPedido.Value = 0;

                cbPagamento.SelectedIndex = 0;
                cbSaboresCobertura.SelectedIndex = -1;
                cbSaboresMassa.SelectedIndex = -1;
                cbSaboresRecheio.SelectedIndex = -1;
                //cbTipoEntrega.Items.Clear();
                cbxProdutos.SelectedIndex = -1;

            }
            else
            {
                cbSaboresCobertura.SelectedIndex = -1;
                cbSaboresMassa.SelectedIndex = -1;
                cbSaboresRecheio.SelectedIndex = -1;
                txbTotal.Clear();

                txbPrecoMassa.Clear();
                txbPrecoCobertura.Clear();
                txbPrecoRecheio.Clear();

            }
        }

        private void CadastroPedidos_Load(object sender, EventArgs e)
        {
            
        }

        //---------------------------------------------------------------------------------------------------

        //ComboBox-------------------------------------------------------------------------------------------
        double[] preco = {0,0,0};
        //Soma dos preços======================================================
        void somaPreco(TextBox Alvo, int posicao)
        {
            if (txbUnidades.Value != 0)
            {
                preco[posicao] = double.Parse((Alvo.Text).Replace("R$", "").Replace(",", "."));
                txbTotal.Text = "R$" + ((preco[0] + preco[1] + preco[2]) * double.Parse(txbUnidades.Value.ToString())).ToString();
                txbTotal.Text = txbTotal.Text.Insert(txbTotal.Text.Length - 2, ".");
            }
            else txbTotal.Clear();
        }
        private void txbUnidades_ValueChanged(object sender, EventArgs e)
        {
            if (txbUnidades.Value != 0 && txbPrecoMassa.Text != "")
            {
                txbTotal.Text = "R$" + ((preco[0] + preco[1] + preco[2]) * double.Parse(txbUnidades.Value.ToString())).ToString();
                txbTotal.Text = txbTotal.Text.Insert(txbTotal.Text.Length - 2, ".");
            }
            else txbTotal.Clear();
        }
        //=====================================================================
        //Produtos=============================================================
        private void testSabores()
        {
            if (cbxProdutos.Text == "")
            {
                gbMassa.Enabled = false;
                gbRecheio.Enabled = false;
                gbCobertura.Enabled = false;
            }
            else
            {
                gbMassa.Enabled = true;
                gbRecheio.Enabled = true;
                gbCobertura.Enabled = true;
            }
        }
        private void cbxProdutos_Click(object sender, EventArgs e)
        {
            addSabores(0);
        }
        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            testSabores();
        }
        //====================================================================
        void addSabores(int atrib = 0)
        {
            try
            {
                if (atrib == 0) //Produtos
                {
                    delTudo(1);
                    utl.ManipListas(cbxProdutos, utl.Conexao("SELECT Produto FROM Produtos", 4));
                    testSabores();
                }
                else if (atrib == 1) //Sabor de Massa
                {
                    precoM.Clear();
                    preco[0] = 0;
                    txbPrecoMassa.Clear();
                    string inter = utl.Conexao("SELECT Massa FROM Produtos WHERE Produto = '" + cbxProdutos.SelectedItem + "'", 5);
                    ArrayList array = new ArrayList(inter.Split('&'));
                    cbSaboresMassa.Items.Clear();
                    foreach (string s in array)
                    {
                        string[] teste = new string[2];
                        teste = s.Split('-');
                        cbSaboresMassa.Items.Add(teste[0]);
                        precoM.Add(teste[1]);
                    }
                }
                else if (atrib == 2) //Sabores de Recheio
                {
                    precoM.Clear();
                    preco[1] = 0;
                    txbPrecoRecheio.Clear();
                    string inter = utl.Conexao("SELECT Recheio FROM Produtos WHERE Produto = '" + cbxProdutos.SelectedItem + "'", 5);
                    ArrayList array = new ArrayList(inter.Split('&'));
                    cbSaboresRecheio.Items.Clear();
                    foreach (string s in array)
                    {
                        string[] teste = new string[2];
                        teste = s.Split('-');
                        cbSaboresRecheio.Items.Add(teste[0]);
                        precoM.Add(teste[1]);
                    }
                }
                else if (atrib == 3) //Sabores de Cobertura
                {
                    precoM.Clear();
                    preco[2] = 0;
                    txbPrecoCobertura.Clear();
                    string inter = utl.Conexao("SELECT Cobertura FROM Produtos WHERE Produto = '" + cbxProdutos.SelectedItem + "'", 5);
                    ArrayList array = new ArrayList(inter.Split('&'));
                    cbSaboresCobertura.Items.Clear();
                    foreach (string s in array)
                    {
                        string[] teste = new string[2];
                        teste = s.Split('-');
                        cbSaboresCobertura.Items.Add(teste[0]);
                        precoM.Add(teste[1]);
                    }
                }
            }
            catch (Exception erro) { delTudo(0); }
        }
        //Sabores de Massa====================================================
        ArrayList precoM = new ArrayList();
        private void cbSaboresMassa_Click(object sender, EventArgs e)
        {
            try
            {
                addSabores(1);
                //utl.ManipListas(cbSaboresMassa, utl.Conexao("SELECT Massa FROM Produtos WHERE Produto = '" + cbxProdutos.SelectedItem + "'", 5));
            
                
            }
            catch (Exception erro)
            {
                utl.Mensagem(erro.Message);
            }
        }
        private void cbSaboresMassa_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            string[] inter = new string[2];
            string i = cbSaboresMassa.SelectedItem.ToString();
            inter = i.Split('-');
            txbPrecoMassa.Text = inter[1];
            cbSaboresMassa.Text = inter[0];
            */
            if (cbSaboresMassa.SelectedIndex != -1)
            {
                txbPrecoMassa.Text = precoM[cbSaboresMassa.SelectedIndex].ToString();
                somaPreco(txbPrecoMassa, 0);
            }
            
        }
        //=====================================================================

        //Sabores de Recheio===================================================
        private void cbSaboresRecheio_Click(object sender, EventArgs e)
        {
            try
            {
                addSabores(2);
                //utl.ManipListas(cbSaboresMassa, utl.Conexao("SELECT Massa FROM Produtos WHERE Produto = '" + cbxProdutos.SelectedItem + "'", 5));
            }
            catch (Exception erro)
            {
                utl.Mensagem(erro.Message);
            }


        }
        private void cbSaboresRecheio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSaboresRecheio.SelectedIndex != -1)
            {
                txbPrecoRecheio.Text = precoM[cbSaboresRecheio.SelectedIndex].ToString();
                somaPreco(txbPrecoRecheio, 1);
            }
        }
        //=====================================================================

        //Sabores de Cobertura=================================================
        private void cbSaboresCobertura_Click(object sender, EventArgs e)
        {
            try
            {
                addSabores(3);
                //utl.ManipListas(cbSaboresMassa, utl.Conexao("SELECT Massa FROM Produtos WHERE Produto = '" + cbxProdutos.SelectedItem + "'", 5));
            }
            catch (Exception erro)
            {
                utl.Mensagem(erro.Message);
            }
        }

        private void cbSaboresCobertura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSaboresCobertura.SelectedIndex != -1)
            {
                txbPrecoCobertura.Text = precoM[cbSaboresCobertura.SelectedIndex].ToString();
                somaPreco(txbPrecoCobertura, 2);
            }
        }
        //=====================================================================

        //MenuStrip------------------------------------------------------------------------------------------
        //Cadastros============================================================
        private void btnCadastrarProdutos_Click(object sender, EventArgs e)
        {
            CadastroProduto CadProdutos = new CadastroProduto();
            CadProdutos.ShowDialog();

        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            CadastroClientes CadClientes = new CadastroClientes();
            CadClientes.ShowDialog();
        }
        //=====================================================================

        //Consultas============================================================
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Consultas Consultas = new Consultas();
            Consultas.ShowDialog();
        }


        //=====================================================================

        //Sobre================================================================
        private void btnQuemSomos_Click(object sender, EventArgs e)
        {
            QuemSomos Sobre = new QuemSomos();
            Sobre.ShowDialog();
        }

        //=====================================================================

        //Arquivo==============================================================
        private void btnResetBanco_Click(object sender, EventArgs e)
        {
            if (utl.Mensagem("Deseja mesmo restaurar o Banco de Dados? Esta ação não poderá ser desfeita.", 1) == 0)
            {
                try
                {
                    //Directory.Delete(utl.Diretorio);
                    utl.Conexao("DELETE * FROM Produtos", atrib: 1);
                    utl.Conexao("DELETE * FROM Pedidos", atrib: 1);
                    utl.Conexao(" DELETE * FROM Clientes");

                }
                catch (Exception erro)
                {
                    utl.Mensagem(erro.Message);
                }
            }
        }
        private void exportarBancoDeDados_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.Copy((utl.Diretorio + utl.Arquivo), (folderBrowserDialog1.SelectedPath + utl.Arquivo), false);
                    utl.Mensagem("Banco de Dados exportado para o diretório: " + folderBrowserDialog1.SelectedPath);
                }
            }
            catch (Exception erro)
            {
                utl.Mensagem(erro.Message);
            }
        }

        //=====================================================================

        //---------------------------------------------------------------------------------------------------

        //Consulta dos Clientes------------------------------------------------------------------------------
        int ClienteValid = 0;
        void buscaCadastro()
        {
            try
            {
                String[] dados = new String[4];
                string inter = utl.Conexao("SELECT * FROM Clientes WHERE CPF = '" + txbCPF.Text + "'", 2);

                dados = inter.Split('&');
                txbNomeCliente.Text = dados[1];
                txbEnderecoEntrega.Text = dados[2];
                txbTelefoneCliente.Text = dados[3];
                ClienteValid = 1;

            }
            catch (Exception erro) { utl.Mensagem(utl.msg[5]); ClienteValid = 0; }

        }
        private void btnBuscarCadastro_Click(object sender, EventArgs e)
        {
            buscaCadastro();
        }
        private void txbCodigoPedido_ValueChanged(object sender, EventArgs e)
        {
            delTudo();
            if (txbCodigoPedido.Value == 0)
            {
                gbCliente.Enabled = false;
                gbDetalhesPedido.Enabled = false;
                gbEntregas.Enabled = false;
                gbxPagamento.Enabled = false;
            }
            else
            {
                gbCliente.Enabled = true;
                gbDetalhesPedido.Enabled = true;
                gbEntregas.Enabled = true;
                gbxPagamento.Enabled = true;
            }
        }
        //---------------------------------------------------------------------------------------------------

        //Consulta de Pedidos--------------------------------------------------------------------------------
        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbCodigoPedido.Value > 0)
                {
                    /*
                    cbxProdutos.Items.Clear();
                    cbxProdutos.Items.Add(utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 1));
                    cbxProdutos.SelectedIndex = 0;
                    */
                    cbxProdutos.SelectedIndex = cbxProdutos.Items.IndexOf(utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 1));

                    txbUnidades.Value = decimal.Parse(utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 2));
                    Thread.Sleep(1000);
                    addSabores(1);
                    cbSaboresMassa.SelectedIndex = cbSaboresMassa.Items.IndexOf(utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 3));
                    txbExtraMassa.Text = utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 4);

                    addSabores(2);
                    cbSaboresRecheio.SelectedIndex = cbSaboresRecheio.Items.IndexOf(utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 5));
                    txbExtraRecheio.Text = utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 6);

                    addSabores(3);
                    cbSaboresCobertura.SelectedIndex = cbSaboresCobertura.Items.IndexOf(utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 7));
                    txbExtraCobertura.Text = utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 8);

                    txbCPF.Text = utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 9);
                    
                    cbPagamento.SelectedIndex = cbPagamento.Items.IndexOf(utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 11));
                    dtpDataEntrega.Value = DateTime.Parse(utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 12));
                    cbTipoEntrega.SelectedIndex = cbTipoEntrega.Items.IndexOf(utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 13));
                    txbEnderecoEntrega.Text = utl.Conexao("SELECT * FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value, 6, 14);
                    buscaCadastro();
                }
            }
            catch (Exception erro) { utl.Mensagem(utl.msg[5]); }
        }
        
        //---------------------------------------------------------------------------------------------------

        //Botoes Inferiores----------------------------------------------------------------------------------
        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if (utl.Mensagem(utl.msg[0], 1) == 0)
            {
                delTudo();
                testSabores();
            }
            else { }


        }

        private void btnAlterarPedido_Click(object sender, EventArgs e)
        {
            if (cbxProdutos.Text != "" && cbSaboresMassa.Text != "" && txbUnidades.Value > 0 && txbCodigoPedido.Value > 0 && (ClienteValid == 1) && txbTotal.Text != "" && cbPagamento.Text != "" && cbTipoEntrega.Text != "")
            {
                if (utl.Mensagem(utl.msg[3], 1) == 0)
                {
                    utl.Conexao("UPDATE Pedidos SET Codigo = " + txbCodigoPedido.Value + " , Produto = '" + cbxProdutos.Text + "', Unidades = '" + txbUnidades.Value + "', SaborMassa = '" + cbSaboresMassa.Text + "', ExtraMassa = '" + txbExtraMassa.Text + "', SaborRecheio = '" + cbSaboresRecheio.Text + "', ExtraRecheio = '" + txbExtraRecheio.Text + "', SaborCobertura = '" + cbSaboresCobertura.Text + "', ExtraCobertura = '" + txbExtraCobertura.Text + "', CPF = '" + txbCPF.Text + "', TotalPagamento = '" + txbTotal.Text + "', TipoPagamento = '" + cbPagamento.Text + "', DataEntrega = '" + dtpDataEntrega.Value.Date + "', TipoEntrega = '" + cbTipoEntrega.Text + "', EnderecoEntrega = '" + txbEnderecoEntrega.Text + "'");
                }
            }
            else utl.Mensagem(utl.msg[4]);

        }


        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            if (cbxProdutos.Text != "" && cbSaboresMassa.Text != "" && txbUnidades.Value > 0 && txbCodigoPedido.Value > 0 && (ClienteValid == 1) && txbTotal.Text != "" && cbPagamento.Text != "" && cbTipoEntrega.Text != "")
            {
                if (utl.Mensagem(utl.msg[1], 1) == 0)
                {
                    utl.Conexao("INSERT INTO Pedidos(Codigo, Produto, Unidades, SaborMassa, ExtraMassa, SaborRecheio, ExtraRecheio, SaborCobertura, ExtraCobertura, CPF, TotalPagamento, TipoPagamento, DataEntrega, TipoEntrega, EnderecoEntrega) " +
                                "VALUES(" + txbCodigoPedido.Value + " , '" + cbxProdutos.Text + "', '" + txbUnidades.Value + "', '" + cbSaboresMassa.Text + "', '" + txbExtraMassa.Text + "', '" + cbSaboresRecheio.Text + "', '" + txbExtraRecheio.Text + "', '" + cbSaboresCobertura.Text + "', '" + txbExtraCobertura.Text + "', '" + txbCPF.Text + "', '" + txbTotal.Text + "', '" + cbPagamento.Text + "', '" + dtpDataEntrega.Value.Date + "', '" + cbTipoEntrega.Text + "', '" + txbEnderecoEntrega.Text + "')");
                    if (utl.Mensagem("Deseja gerar um recibo do pedido?", 1) == 0)
                    {
                        utl.Conexao("DELETE * FROM Recibos", atrib:1);
                        utl.Conexao("INSERT INTO Recibos(ID, CodPedido, Pedido, PrecoTotal, DataEntrega) VALUES(0, " + txbCodigoPedido.Value + ", '" + cbxProdutos.SelectedItem + "', '" + txbTotal.Text + "', '" + dtpDataEntrega.Value.Date + "')");
                        utl.Mensagem("Vá na tela CONSULTA para ver os resultados e imprimir o RECIBO");
                    }
                }
            }
            else utl.Mensagem(utl.msg[4]);
        }

        private void btnAtualizarTotal_Click(object sender, EventArgs e)
        {
            txbTotal.Text = "0";
        }

        private void btnDeletarPedido_Click(object sender, EventArgs e)
        {
            if (txbCodigoPedido.Value > 0)
            {
                if (utl.Mensagem(utl.msg[2], 1) == 0)
                {
                    utl.Conexao("DELETE FROM Pedidos WHERE Codigo = " + txbCodigoPedido.Value);
                    delTudo();
                }
            }
        }










    }
}
