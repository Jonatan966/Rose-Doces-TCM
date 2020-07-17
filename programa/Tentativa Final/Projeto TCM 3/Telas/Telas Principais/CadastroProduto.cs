using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCM_3
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }


        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            delTudo(1);
        }
        private void txbCodProduto_ValueChanged(object sender, EventArgs e)
        {
            if (txbCodProduto.Value == 0)
            {
                delTudo(1);
            }
            else delTudo(2);
        }

        private void delTudo(int func = 0)
        {
            txbNomeProduto.Clear();
            txbPrecoCobertura.Clear();
            txbPrecoMassa.Clear();
            txbPrecoRecheio.Clear();
            txbSaborCobertura.Clear();
            txbSaborMassa.Clear();
            txbSaborRecheio.Clear();

            lbSaborCobertura.Items.Clear();
            lbSaborMassa.Items.Clear();
            lbSaborRecheio.Items.Clear();
            
            if (func == 1) //Impossibilita o usuario de inserir dados
            {
                txbNomeProduto.Enabled = false;
                txbPrecoCobertura.Enabled = false;
                txbPrecoMassa.Enabled = false;
                txbPrecoRecheio.Enabled = false;
                txbSaborCobertura.Enabled = false;
                txbSaborMassa.Enabled = false;
                txbSaborRecheio.Enabled = false;

                lbSaborCobertura.Enabled = false;
                lbSaborMassa.Enabled = false;
                lbSaborRecheio.Enabled = false;

                btnAddCobertura.Enabled = false;
                btnAddMassa.Enabled = false;
                btnAddRecheio.Enabled = false;
                btnAltCobertura.Enabled = false;
                btnAltRecheio.Enabled = false;
                btnAltMassa.Enabled = false;
                btnRemCobertura.Enabled = false;
                btnRemMassa.Enabled = false;
                btnRemRecheio.Enabled = false;

                btnFinalizarCadastro.Enabled = false;
                btnAlterarCadastro.Enabled = false;
                btnDeletarProduto.Enabled = false;
                btnCancelarCadastro.Enabled = false;
                btnBuscarCadastro.Enabled = false;
            }
            else if (func == 2)
            {
                txbNomeProduto.Enabled = true;
                txbPrecoCobertura.Enabled = true;
                txbPrecoMassa.Enabled = true;
                txbPrecoRecheio.Enabled = true;
                txbSaborCobertura.Enabled = true;
                txbSaborMassa.Enabled = true;
                txbSaborRecheio.Enabled = true;

                lbSaborCobertura.Enabled = true;
                lbSaborMassa.Enabled = true;
                lbSaborRecheio.Enabled = true;

                btnAddCobertura.Enabled = true;
                btnAddMassa.Enabled = true;
                btnAddRecheio.Enabled = true;
                btnAltCobertura.Enabled = true;
                btnAltRecheio.Enabled = true;
                btnAltMassa.Enabled = true;
                btnRemCobertura.Enabled = true;
                btnRemMassa.Enabled = true;
                btnRemRecheio.Enabled = true;

                btnFinalizarCadastro.Enabled = true;
                btnAlterarCadastro.Enabled = true;
                btnDeletarProduto.Enabled = true;
                btnCancelarCadastro.Enabled = true;
                btnBuscarCadastro.Enabled = true;
            }
            else txbCodProduto.Value = 0;

        }
        //Controles Principais-------------------------------------------------------------------------------
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            if (utl.Mensagem(utl.msg[0], 1) == 0)
            {
                delTudo();
            }
        }

        private void btnFinalizarCadastro_Click(object sender, EventArgs e) //Responsavel por finalizar os cadastros
        {
            int i = 0, contador = -1;
            try
            {
                if (txbNomeProduto.Text == "" || lbSaborMassa.Items.Count == 0)
                {
                    utl.Mensagem("Há dados faltando");
                }
                else if (utl.Mensagem(utl.msg[1], 1) == 0)
                {
                    String[] fMassas = new string[lbSaborMassa.Items.Count];
                    String[] fRecheios = new string[lbSaborRecheio.Items.Count];
                    String[] fCoberturas = new string[lbSaborCobertura.Items.Count];
                    do
                    {
                        switch (contador)
                        {
                            case -1:
                                if (lbSaborCobertura.Items.Count == 0)
                                {
                                    lbSaborCobertura.Items.Add("Nenhum-R$000.00");
                                    fCoberturas = new string[lbSaborCobertura.Items.Count];
                                }
                                if (lbSaborRecheio.Items.Count == 0)
                                {
                                    lbSaborRecheio.Items.Add("Nenhum-R$000.00");
                                    fRecheios = new string[lbSaborRecheio.Items.Count];
                                }
                                contador++;

                                break;
                            case 0:
                                for (i = 0; i <= lbSaborMassa.Items.Count - 1; )
                                {
                                    lbSaborMassa.SelectedIndex = i;
                                    fMassas[i] = lbSaborMassa.SelectedItem.ToString();
                                    i++;
                                }
                                contador++;
                                break;
                            case 1:
                                for (i = 0; i <= lbSaborRecheio.Items.Count - 1; )
                                {
                                    lbSaborRecheio.SelectedIndex = i;
                                    fRecheios[i] = lbSaborRecheio.SelectedItem.ToString();
                                    i++;
                                }
                                contador++;
                                break;
                            case 2:
                                for (i = 0; i <= lbSaborCobertura.Items.Count - 1; )
                                {
                                    lbSaborCobertura.SelectedIndex = i;
                                    fCoberturas[i] = lbSaborCobertura.SelectedItem.ToString();
                                    i++;
                                }
                                contador++;
                                break;
                        }
                    } while (contador <= 2);
                    utl.Conexao("INSERT INTO Produtos(Codigo, Produto, Massa, Recheio, Cobertura) VALUES ('" + txbCodProduto.Value + "', '" + txbNomeProduto.Text + "', '" + (String.Join("& ", fMassas)) + "', '" + (String.Join("& ", fRecheios)) + "', '" + (String.Join("& ", fCoberturas)) + "')");
                }
            }
            catch (Exception erro) { utl.Mensagem(erro.Message); }
        }

        private void btnAlterarCadastro_Click(object sender, EventArgs e) //Responsavel por alterar os cadastros
        {
            String[] fMassas = new string[lbSaborMassa.Items.Count];
            String[] fRecheios = new string[lbSaborRecheio.Items.Count];
            String[] fCoberturas = new string[lbSaborCobertura.Items.Count];
            int i = 0, contador = 0;
            try
            {
                if (txbCodProduto.Value == 0 || txbNomeProduto.Text == "")
                {
                    utl.Mensagem("Nome e/ou código do produto incorretos");
                }
                else if (utl.Mensagem(utl.msg[3], 1) == 0)
                {
                    do
                    {
                        switch (contador)
                        {
                            case 0:
                                for (i = 0; i <= lbSaborMassa.Items.Count - 1; )
                                {
                                    lbSaborMassa.SelectedIndex = i;
                                    fMassas[i] = lbSaborMassa.SelectedItem.ToString();
                                    i++;
                                }
                                contador++;
                                break;
                            case 1:
                                for (i = 0; i <= lbSaborRecheio.Items.Count - 1; )
                                {
                                    lbSaborRecheio.SelectedIndex = i;
                                    fRecheios[i] = lbSaborRecheio.SelectedItem.ToString();
                                    i++;
                                }
                                contador++;
                                break;
                            case 2:
                                for (i = 0; i <= lbSaborCobertura.Items.Count - 1; )
                                {
                                    lbSaborCobertura.SelectedIndex = i;
                                    fCoberturas[i] = lbSaborCobertura.SelectedItem.ToString();
                                    i++;
                                }
                                contador++;
                                break;
                        }
                    } while (contador <= 2);
                    utl.Conexao("UPDATE Produtos SET Produto = '" + txbNomeProduto.Text + "', Massa = '" + (String.Join("& ", fMassas)) + "', Recheio = '" + (String.Join("& ", fRecheios)) + "', Cobertura = '" + (String.Join("& ", fCoberturas)) + "' WHERE Codigo = " + txbCodProduto.Value);
                }
            }
            catch (Exception erro) { utl.Mensagem(erro.Message); }
        }

        private void btnBuscarCadastro_Click(object sender, EventArgs e) //Responsável por buscar os cadastros
        {
            try
            {
                if (txbCodProduto.Value == 0)
                {
                    utl.Mensagem("Digite um valor acima de 0");
                }
                else
                {
                    String[] dados = new String[4];
                    string inter = utl.Conexao("SELECT Produto, Massa, Recheio, Cobertura FROM Produtos WHERE Codigo = " + txbCodProduto.Value, 2);
                    dados = inter.Split('&');

                    txbNomeProduto.Text = dados[0];
                    utl.ManipListas(lbSaborMassa, dados[1]);
                    utl.ManipListas(lbSaborRecheio, dados[2]);
                    utl.ManipListas(lbSaborCobertura, dados[3]);
                }
            }
            catch (Exception erro)
            {
                
               utl.Mensagem("Valor não encontrado");
            }
        }

        private void btnDeletarProduto_Click(object sender, EventArgs e)
        {
            if (txbNomeProduto.Text == "")
            {
                utl.Mensagem(utl.msg[5]);
            }
            if (utl.Mensagem(utl.msg[2], 1) == 0)
            {
                utl.Conexao("DELETE FROM Produtos WHERE Codigo = " + txbCodProduto.Value);
                delTudo();
            }
        }
        //---------------------------------------------------------------------------------------------------

        //Eventos Uteis--------------------------------------------------------------------------------------
        private void txbSemNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (Char.IsNumber(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSymbol(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txbSemLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (char.IsSymbol(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        //---------------------------------------------------------------------------------------------------

        //Bloco de comandos referente a possibilidade de mover o Formulário----------------------------------
        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;
        Utils utl = new Utils();

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

        //Cadastro de Sabores--------------------------------------------------------------------------------
        //Sabores de Massa===============================================================    
        private void btnAddMassa_Click(object sender, EventArgs e) 
        {
            if (lbSaborMassa.FindString(txbSaborMassa.Text + "-" + txbPrecoMassa.Text) == -1)
            {
                if (txbPrecoMassa.TextNoFormatting() != "" && txbPrecoMassa.TextNoFormatting().Length == 5)
                    utl.ManipListas(lbSaborMassa, txbSaborMassa, txbPrecoMassa, 1);
                else utl.Mensagem(utl.msg[4]);
            }
            else utl.Mensagem(utl.msg[7]);
        }

        private void btnAltMassa_Click(object sender, EventArgs e) 
        {
            if (lbSaborMassa.FindString(txbSaborMassa.Text + "-" + txbPrecoMassa.Text) == -1)
            {
                if (txbPrecoMassa.TextNoFormatting() != "" && txbPrecoMassa.TextNoFormatting().Length == 5)
                    utl.ManipListas(lbSaborMassa, txbSaborMassa, txbPrecoMassa, 2);
                else utl.Mensagem(utl.msg[4]);
            }
            else utl.Mensagem(utl.msg[7]);
        }

        private void btnRemMassa_Click(object sender, EventArgs e) { utl.ManipListas(lbSaborMassa, txbSaborMassa, txbPrecoMassa, 3); }

        private void lbSaborMassa_SelectedIndexChanged(object sender, EventArgs e) { utl.ManipListas(lbSaborMassa, txbSaborMassa, txbPrecoMassa, 4); }
        //===============================================================================

        //Sabores de Recheio=============================================================
        private void btnAddRecheio_Click(object sender, EventArgs e) 
        {
            if (lbSaborRecheio.FindString(txbSaborRecheio.Text + "-" + txbPrecoRecheio.Text) == -1)
            {

                if (txbPrecoRecheio.TextNoFormatting() != "" && txbPrecoRecheio.TextNoFormatting().Length == 5)
                    utl.ManipListas(lbSaborRecheio, txbSaborRecheio, txbPrecoRecheio, 1);
                else utl.Mensagem(utl.msg[4]);
            }
            else utl.Mensagem(utl.msg[7]);

        }

        private void btnAltRecheio_Click(object sender, EventArgs e) 
        {
            if (lbSaborRecheio.FindString(txbSaborRecheio.Text + "-" + txbPrecoRecheio.Text) == -1)
            {
                if (txbPrecoRecheio.TextNoFormatting() != "" && txbPrecoRecheio.TextNoFormatting().Length == 5)
                    utl.ManipListas(lbSaborRecheio, txbSaborRecheio, txbPrecoRecheio, 2);
                else utl.Mensagem(utl.msg[4]);
            }
            else utl.Mensagem(utl.msg[7]);
        }

        private void btnRemRecheio_Click(object sender, EventArgs e) { utl.ManipListas(lbSaborRecheio, txbSaborRecheio, txbPrecoRecheio, 3); }

        private void lbSaborRecheio_SelectedIndexChanged(object sender, EventArgs e) { utl.ManipListas(lbSaborRecheio, txbSaborRecheio, txbPrecoRecheio, 4); }
        //===============================================================================

        //Sabores de Cobertura=============================================================
        private void btnAddCobertura_Click(object sender, EventArgs e) 
        {
            if (lbSaborCobertura.FindString(txbSaborCobertura.Text + "-" + txbPrecoCobertura.Text) == -1)
            {
                if (txbPrecoCobertura.TextNoFormatting() != "" && txbPrecoCobertura.TextNoFormatting().Length == 5)
                    utl.ManipListas(lbSaborCobertura, txbSaborCobertura, txbPrecoCobertura, 1);
                else utl.Mensagem(utl.msg[4]);
            }
            else utl.Mensagem(utl.msg[7]);
        }

        private void btnAltCobertura_Click(object sender, EventArgs e) 
        {
            if (lbSaborCobertura.FindString(txbSaborCobertura.Text + "-" + txbPrecoCobertura.Text) == -1)
            {
                if (txbPrecoCobertura.TextNoFormatting() != "" && txbPrecoCobertura.TextNoFormatting().Length == 5)
                    utl.ManipListas(lbSaborCobertura, txbSaborCobertura, txbPrecoCobertura, 2);
                else utl.Mensagem(utl.msg[4]);
            }
            else utl.Mensagem(utl.msg[7]);
        }

        private void btnRemCobertura_Click(object sender, EventArgs e) { utl.ManipListas(lbSaborCobertura, txbSaborCobertura, txbPrecoCobertura, 3); }

        private void lbSaborCobertura_SelectedIndexChanged(object sender, EventArgs e) { utl.ManipListas(lbSaborCobertura, txbSaborCobertura, txbPrecoCobertura, 4); }




        //===============================================================================

        //---------------------------------------------------------------------------------------------------

    }
}
