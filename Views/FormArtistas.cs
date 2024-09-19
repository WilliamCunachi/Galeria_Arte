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
    public partial class FormArtistas : Form
    {
        private ArtistaController artistaController = new ArtistaController();

        public FormArtistas()
        {
            InitializeComponent();
            CargarArtistas();
        }
        private void CargarArtistas()
        {
            listBoxArtistas.Items.Clear();
            var artistas = artistaController.ObtenerArtistas();
            foreach (var artista in artistas)
            {
                listBoxArtistas.Items.Add(artista);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoArtista = new Artista
            {
                Nombre = txtNombre.Text
            };
            artistaController.AgregarArtista(nuevoArtista);
            CargarArtistas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listBoxArtistas.SelectedItem != null)
            {
                var artistaSeleccionado = (Artista)listBoxArtistas.SelectedItem;
                artistaSeleccionado.Nombre = txtNombre.Text;
                artistaController.ModificarArtista(artistaSeleccionado);
                CargarArtistas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxArtistas.SelectedItem != null)
            {
                var artistaSeleccionado = (Artista)listBoxArtistas.SelectedItem;
                artistaController.EliminarArtista(artistaSeleccionado.ID_Artista);
                CargarArtistas();
            }
        }

        private void listBoxArtistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxArtistas.SelectedItem != null)
            {
                var artistaSeleccionado = (Artista)listBoxArtistas.SelectedItem;
                txtNombre.Text = artistaSeleccionado.Nombre;
            }
        }
    }
}
