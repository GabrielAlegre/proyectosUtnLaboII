using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BcI101MiPrimerCRUD
{
    public static class PersonaDAO
    {
        static string stringConexion;
        static SqlCommand command;
        static SqlConnection connection;
        static PersonaDAO()
        {
            stringConexion = @"Data Source=.;Initial Catalog=MiPrimerCRUD;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(stringConexion);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static int Guardar(Persona persona)
        {
            int columnasAfectadas = 0;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO Persona (NOMBRE, APELLIDO) VALUES (@Nombre, @Apellido)";
                command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                command.Parameters.AddWithValue("@Apellido", persona.Apellido);
                columnasAfectadas = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new SqlCrudException("Fallo el guardar persona de la clase PersonaDAO\n"+e.Message);
            }
            finally
            {
                connection.Close();
            }

            return columnasAfectadas;
        }

        public static int Borrar(int id)
        {
            int columnasAfectadas = 0;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM Persona WHERE ID = @Id";
                command.Parameters.AddWithValue("@Id", id);
                columnasAfectadas = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new SqlCrudException("Fallo el borrar persona de la clase PersonaDAO\n" + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return columnasAfectadas;
        }

        public static int Modificar(string nuevoNombre,string apellido, int idDeLaPersonaModificar)
        {
            int columnasAfectadas = 0;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE Persona SET NOMBRE = @Nombre, APELLIDO = @Apellido WHERE ID = @Id";
                command.Parameters.AddWithValue("@Nombre", nuevoNombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Id", idDeLaPersonaModificar);
                columnasAfectadas = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new SqlCrudException("Fallo el modificar persona de la clase PersonaDAO\n" + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return columnasAfectadas;
        }

        public static List<Persona> Leer()
        {
            List<Persona> listaDePersonas = new List<Persona>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Persona";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        listaDePersonas.Add(new Persona(Convert.ToInt32(dataReader["ID"]) , dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString()));
                    }
                }

                return listaDePersonas;
            }
            catch (Exception e)
            {
                throw new SqlCrudException("Fallo el leer persona de la clase PersonaDAO\n" + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static Persona LeerPorId(int id)
        {
            Persona personaEncontrada = null;

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM Persona WHERE ID = @Id";
                command.Parameters.AddWithValue("@Id", id);

                //command.ExecuteReader() <- ejecuta la consulta
                //SqlDataReader dataReader <- donde se guardara la consulta
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        personaEncontrada = new Persona(Convert.ToInt32(dataReader["ID"]), dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                throw new SqlCrudException("Fallo el leer persona de la clase PersonaDAO\n" + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return personaEncontrada;
        }

    }
}
