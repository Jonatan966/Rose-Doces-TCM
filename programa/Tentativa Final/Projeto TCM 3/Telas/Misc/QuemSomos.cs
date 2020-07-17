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
    public partial class QuemSomos : Form
    {
        public QuemSomos()
        {
            InitializeComponent();
        }

        //Bloco de comandos referente a possibilidade de mover o Formulário----------------------------------
        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;
        public void QuemSomos_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                Arrastando = false;
        }

        public void QuemSomos_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                
                Arrastando = true;
                ArrastarCursor = Cursor.Position;
                ArrastarForm = this.Location;
                
            }
        }

        private void QuemSomos_MouseMove(object sender, MouseEventArgs e)
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
