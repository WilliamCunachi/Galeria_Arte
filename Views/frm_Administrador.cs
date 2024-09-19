using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galeria_Arte.Views;
namespace Galeria_Arte.Views
{
    public partial class frm_Administrador : Form
    {
        public frm_Administrador()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void agregarArtistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArtistas formArtistas = new FormArtistas();
            formArtistas.ShowDialog();
            this.Show();
        }

        private void agregarObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormObras formArtistas = new FormObras();
            formArtistas.ShowDialog();
            this.Show();
        }
    }
}
