using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Incidencias
{
    public partial class PantallaIincio : Form
    {
        string TipoUsuario;
        public PantallaIincio(string TipoUsuario)
        {
            InitializeComponent();
            this.TipoUsuario = TipoUsuario;
        }

        private void PantallaIincio_Load(object sender, EventArgs e)
        {

        }
    }
}
