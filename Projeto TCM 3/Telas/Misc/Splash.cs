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

namespace Projeto_TCM_3
{
    public partial class Splash : Form
    {
        Utils utl = new Utils();
       
        public Splash()
        {
            /*
            var arquivo = Properties.Resources.RosseDoces;
            var byteArquivo = new byte[arquivo.Length];
            arquivo.Read(byteArquivo, 0, byteArquivo.Length);
           */
           InitializeComponent();
            
        }
    }
}
