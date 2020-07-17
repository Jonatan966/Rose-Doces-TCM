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
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        Utils utl = new Utils();
        //Controles Principais-----------------------------------------------------------------------------------------
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-------------------------------------------------------------------------------------------------------------
        
        //Bloco de comandos referente a possibilidade de mover o Formulário--------------------------------------------
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
        //-------------------------------------------------------------------------------------------------------------

        //Controles Principais-----------------------------------------------------------------------------------------
        //Este método é responsável por impedir o usuário de digitar números em uma caixa de texto===========
        private void txbSemNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSymbol(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        //===================================================================================================

        //Este método é responsável por buscar cadastros=====================================================
        private void btnBuscarCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                String[] dados = new String[4];
                string inter = utl.Conexao("SELECT * FROM Clientes WHERE CPF = '" + txbCPF.Text + "'", 2);
                
                dados = inter.Split('&');
                txbNome.Text = dados[1];
                txbEndereco.Text = dados[2];
                txbTelefone.Text = dados[3];


            }
            catch (Exception erro) { utl.Mensagem(erro.Message); }
        }
        //===================================================================================================

        //Este método é responsável por cancelar cadastros===================================================
        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            if (utl.Mensagem(utl.msg[0], 1) == 0)
            {
                txbCPF.Clear();
                txbEndereco.Clear();
                txbNome.Clear();
                txbTelefone.Clear();
            }
        }
        //===================================================================================================

        //Este método é responsável por fazer o cadastro=====================================================
        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbCPF.TextNoFormatting() != "" && (txbCPF.TextNoFormatting()).Length == 11 && txbEndereco.Text != "" && txbNome.Text != "" && txbTelefone.Text != "" && utl.Mensagem(utl.msg[1], 1) == 0)
                    utl.Conexao("INSERT INTO Clientes(CPF, Nome, Telefone, Endereco) VALUES ('" + txbCPF.Text + "', '" + txbNome.Text + "', '" + txbTelefone.Text + "', '" + txbEndereco.Text + "')");


                else utl.Mensagem(utl.msg[4]);
            }
            catch (Exception erro) { utl.Mensagem(erro.Message); }
        }
        //===================================================================================================

        //Este método é responsável por deletar o cadastro===================================================
        private void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbCPF.TextNoFormatting() != "" || txbEndereco.Text != "" || txbNome.Text != "" || txbTelefone.Text != "" && utl.Mensagem(utl.msg[2], 1) == 0)
                {
                    if (utl.Mensagem(utl.msg[2], 1) == 0)
                    {
                        utl.Conexao("DELETE FROM Clientes WHERE CPF = '" + txbCPF.Text + "'");
                        txbCPF.Clear();
                        txbEndereco.Clear();
                        txbNome.Clear();
                        txbTelefone.Clear();
                    }
                    
                }
            }
            catch (Exception erro) { utl.Mensagem(erro.Message); }

        }
        //===================================================================================================

        //Este método é responsável por alterar o cadastro===================================================
        private void btnAlterarCadastro_Click(object sender, EventArgs e)
        {
            if (txbCPF.TextNoFormatting() != "" && (txbCPF.TextNoFormatting()).Length == 11 && txbEndereco.Text != "" && txbNome.Text != "" && txbTelefone.Text != "")
            {
                if (utl.Mensagem(utl.msg[3], 1) == 0)
                {
                    utl.Conexao("UPDATE Clientes SET Nome = '" + txbNome.Text + "', Telefone = '" + txbTelefone.Text + "', Endereco = '" + txbEndereco.Text + "' WHERE CPF = '" + txbCPF.Text + "'");

                }
            }
            else utl.Mensagem(utl.msg[4]);
        }
        //===================================================================================================

        //-------------------------------------------------------------------------------------------------------------

    }
}
