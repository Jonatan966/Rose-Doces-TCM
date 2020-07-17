using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projeto_TCM_3
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        //Controles Principais-------------------------------------------------------------------------------
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //---------------------------------------------------------------------------------------------------

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
        Utils utl = new Utils();
        private void ConsultaPedidos_Load(object sender, EventArgs e)
        {
            cbConsultas.SelectedIndex = 0;
        }

        private void cbConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtvPedidos.DataSource = utl.Consulta("SELECT * FROM " + cbConsultas.SelectedItem);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.printDocument1.DefaultPageSettings.Landscape = true;
            
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Dados da Tabela - " + cbConsultas.Text;
            printer.SubTitle = "Rose Doces - " + DateTime.Now.Date.ToString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            //printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            //printer.Footer = "Rose Doces";
            printer.FooterSpacing = 15;
            printer.PageSettings.Landscape = false;
            printer.PrintDataGridView(dtvPedidos);
            
        }

    }
}
