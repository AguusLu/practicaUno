using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUno.Models
{
    internal class CervezaBD
    {
        private string connectionString
            = "Data Source=DESKTOP-4UG60OM\\SQLEXPRESS;Initial Catalog=practicaUno;Integrated Security=True;"; //user=;Password=;
        /*
            Data Source= ;
            Initial Catalog= ;
            User= ;
            Password= ;
        */
        //    "DefaultConnection": "Server=DESKTOP-4UG60OM\\SQLEXPRESS;Database=expressions;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False"
        
        public List<Cerveza> getCervezas()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "select nombre, marca, alcohol, cantidad from cerveza";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int cantidad = reader.GetInt32(3);
                    string nombre = reader.GetString(0);
                    Cerveza cerveza = new Cerveza(cantidad, nombre);

                    cerveza.alcohol = reader.GetInt32(2);
                    cerveza.marca = reader.GetString(1);

                    cervezas.Add(cerveza);
                }

                reader.Close();
                connection.Close();
            }
            return cervezas;
        }


        public void agregarCerveza(Cerveza cerveza)
        {
            string query = "insert into cerveza(nombre, marca, alcohol, cantidad) " +
                "values(@nombre, @marca, @alcohol, @cantidad)";

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cerveza.nombre);
                command.Parameters.AddWithValue("@marca", cerveza.marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.cantidad);

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Edit(Cerveza cerveza, int id)
        {
            string query = "update cerveza set nombre=@nombre, " +
                "marca=@marca, alcohol=@alcohol, cantidad=@cantidad " +
                "where id=@id";


            /*update cerveza set nombre='Cerveza', marca='brahama', alcohol=14, cantidad=5 where id=1003 */
            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cerveza.nombre);
                command.Parameters.AddWithValue("@marca", cerveza.marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.cantidad);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Delete(int id)
        {
            string query = "delete from cerveza " +
                "where id=@id";

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
        }
}
