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
    internal class ExposicionesController
    {
        public void AgregarExposicion(Exposicion exposicion)
        {
            using (var connection = Conexion.GetConnection())
            {
                string query = "INSERT INTO Exposiciones (ID_Obra, Fecha) VALUES (@ID_Obra, @Fecha)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Obra", exposicion.ID_Obra);
                    command.Parameters.AddWithValue("@Fecha", exposicion.Fecha);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para modificar una exposición existente
        public void ModificarExposicion(Exposicion exposicion)
        {
            using (var connection = Conexion.GetConnection())
            {
                string query = "UPDATE Exposiciones SET ID_Obra = @ID_Obra, Fecha = @Fecha WHERE ID_Exposicion = @ID_Exposicion";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Obra", exposicion.ID_Obra);
                    command.Parameters.AddWithValue("@Fecha", exposicion.Fecha);
                    command.Parameters.AddWithValue("@ID_Exposicion", exposicion.ID_Exposicion);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar una exposición
        public void EliminarExposicion(int idExposicion)
        {
            using (var connection = Conexion.GetConnection())
            {
                string query = "DELETE FROM Exposiciones WHERE ID_Exposicion = @ID_Exposicion";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Exposicion", idExposicion);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener una lista de todas las exposiciones
        public List<Exposicion> ObtenerExposiciones()
        {
            List<Exposicion> exposiciones = new List<Exposicion>();

            using (var connection = Conexion.GetConnection())
            {
                string query = "SELECT * FROM Exposiciones";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Exposicion exposicion = new Exposicion
                            {
                                ID_Exposicion = reader.GetInt32(0),
                                ID_Obra = reader.GetInt32(1),
                                Fecha = reader.GetDateTime(2)
                            };
                            exposiciones.Add(exposicion);
                        }
                    }
                }
            }

            return exposiciones;
        }
    }
}
