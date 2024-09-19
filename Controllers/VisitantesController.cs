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
    internal class VisitantesController
    {
        public void AgregarVisitante(Visitante visitante)
        {
            using (var connection = Conexion.GetConnection())
            {
                string query = "INSERT INTO Visitantes (Nombre, ID_Exposicion) VALUES (@Nombre, @ID_Exposicion)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", visitante.Nombre);
                    command.Parameters.AddWithValue("@ID_Exposicion", visitante.ID_Exposicion);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para modificar un visitante existente
        public void ModificarVisitante(Visitante visitante)
        {
            using (var connection = Conexion.GetConnection())
            {
                string query = "UPDATE Visitantes SET Nombre = @Nombre, ID_Exposicion = @ID_Exposicion WHERE ID_Visitante = @ID_Visitante";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", visitante.Nombre);
                    command.Parameters.AddWithValue("@ID_Exposicion", visitante.ID_Exposicion);
                    command.Parameters.AddWithValue("@ID_Visitante", visitante.ID_Visitante);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un visitante
        public void EliminarVisitante(int idVisitante)
        {
            using (var connection = Conexion.GetConnection())
            {
                string query = "DELETE FROM Visitantes WHERE ID_Visitante = @ID_Visitante";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Visitante", idVisitante);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener una lista de todos los visitantes
        public List<Visitante> ObtenerVisitantes()
        {
            List<Visitante> visitantes = new List<Visitante>();

            using (var connection = Conexion.GetConnection())
            {
                string query = "SELECT * FROM Visitantes";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Visitante visitante = new Visitante
                            {
                                ID_Visitante = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                ID_Exposicion = reader.GetInt32(2)
                            };
                            visitantes.Add(visitante);
                        }
                    }
                }
            }

            return visitantes;
        }
    }
}
