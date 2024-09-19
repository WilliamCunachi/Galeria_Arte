using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeria_Arte.Config
{
    internal class Conexion
    {
        public static readonly string connetionString;
        static Conexion()
        {
            connetionString = "Server=ALEXIA\\SQLEXPRESS;database=GaleriaArte;uid=sa;pwd=2023022;";

        }
        public static SqlConnection GetConnection()
        {
            try
            {
                var connection = new SqlConnection(connetionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al conectar con la base de datos:{ex.Message}");
                throw;

            }
        }
    }
}
