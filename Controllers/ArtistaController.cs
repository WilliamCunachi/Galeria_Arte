using Galeria_Arte.Config;
using Galeria_Arte.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeria_Arte.Controllers
{
    internal class ArtistaController
    {
        public List<Artista> ObtenerArtistas()
        {
            List<Artista> listaArtistas = new List<Artista>();
            using (var connection = Conexion.GetConnection())
            {
                var query = "SELECT * FROM Artistas";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaArtistas.Add(new Artista
                    {
                        ID_Artista = (int)reader["ID_Artista"],
                        Nombre = reader["Nombre"].ToString()
                    });
                }
            }
            return listaArtistas;
        }

        public void AgregarArtista(Artista artista)
        {
            using (var connection = Conexion.GetConnection())
            {
                var query = "INSERT INTO Artistas (Nombre) VALUES (@Nombre)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", artista.Nombre);
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificarArtista(Artista artista)
        {
            using (var connection = Conexion.GetConnection())
            {
                var query = "UPDATE Artistas SET Nombre=@Nombre WHERE ID_Artista=@ID_Artista";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", artista.Nombre);
                cmd.Parameters.AddWithValue("@ID_Artista", artista.ID_Artista);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarArtista(int id)
        {
            using (var connection = Conexion.GetConnection())
            {
                var query = "DELETE FROM Artistas WHERE ID_Artista=@ID_Artista";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_Artista", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
