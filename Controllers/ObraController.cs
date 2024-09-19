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
    internal class ObraController
    {
        public List<Obra> ObtenerObras()
        {
            List<Obra> listaObras = new List<Obra>();
            using (var connection = Conexion.GetConnection())
            {
                var query = "SELECT * FROM Obras";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaObras.Add(new Obra
                    {
                        ID_Obra = (int)reader["ID_Obra"],
                        Nombre = reader["Nombre"].ToString(),
                        ID_Artista = (int)reader["ID_Artista"]
                    });
                }
            }
            return listaObras;
        }

        public void AgregarObra(Obra obra)
        {
            using (var connection = Conexion.GetConnection())
            {
                var query = "INSERT INTO Obras (Nombre, ID_Artista) VALUES (@Nombre, @ID_Artista)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", obra.Nombre);
                cmd.Parameters.AddWithValue("@ID_Artista", obra.ID_Artista);
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificarObra(Obra obra)
        {
            using (var connection = Conexion.GetConnection())
            {
                var query = "UPDATE Obras SET Nombre=@Nombre, ID_Artista=@ID_Artista WHERE ID_Obra=@ID_Obra";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", obra.Nombre);
                cmd.Parameters.AddWithValue("@ID_Artista", obra.ID_Artista);
                cmd.Parameters.AddWithValue("@ID_Obra", obra.ID_Obra);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarObra(int id)
        {
            using (var connection = Conexion.GetConnection())
            {
                var query = "DELETE FROM Obras WHERE ID_Obra=@ID_Obra";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_Obra", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
