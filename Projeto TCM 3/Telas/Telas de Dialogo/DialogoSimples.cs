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
    public partial class DialogoSimples : Form
    {
        public string mensagem = "";

        public DialogoSimples()
        {
            InitializeComponent();
        }


        private void Dialogos_Load(object sender, EventArgs e)
        {
            lblMsg.Text = mensagem;
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

    }
}
