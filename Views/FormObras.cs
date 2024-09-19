using Galeria_Arte.Controllers;
using Galeria_Arte.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galeria_Arte.Views
{
    public partial class FormObras : Form
    {
        ObraController obrasController = new ObraController();

        public FormObras()
        {
            InitializeComponent();
            CargarObras();
        }
        private void CargarObras()
        {
            listBoxObras.Items.Clear();
            var obras = obrasController.ObtenerObras();
            foreach (var obra in obras)
            {
                listBoxObras.Items.Add($"{obra.ID_Obra} - {obra.Nombre}");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var obra = new Obra
            {
                Nombre = txtNombreObra.Text,
                ID_Artista = int.Parse(txtIDArtista.Text)
            };
            obrasController.AgregarObra(obra);
            CargarObras();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var obra = new Obra
            {
                ID_Obra = int.Parse(txtIDObra.Text),
                Nombre = txtNombreObra.Text,
                ID_Artista = int.Parse(txtIDArtista.Text)
            };
            obrasController.ModificarObra(obra);
            CargarObras();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idObra = int.Parse(txtIDObra.Text);
            obrasController.EliminarObra(idObra);
            CargarObras();
        }

        private void listBoxObras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxObras.SelectedItem != null)
            {
                string[] datos = listBoxObras.SelectedItem.ToString().Split('-');
                txtIDObra.Text = datos[0].Trim();
                txtNombreObra.Text = datos[1].Trim();
            }
        }
    }
}
