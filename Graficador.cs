using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficador_de_UML
{
    public partial class Graficador : Form
    {
        public Graficador(String usuario)
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenid@\n"+usuario;
        }
    }
}
