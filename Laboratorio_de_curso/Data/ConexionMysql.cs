using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_de_curso.Data
{
    internal class ConexionMysql
    {
        private string connectionString = "Server=localhost;Database=db_universidad;Uid=root;Pwd=emmanuelxD";
        MySqlConnection connection;

        //ConstructoR
        public ConexionMysql()
        {
            connection = new MySqlConnection(connectionString);
        }
        //Funcion para leer todos los registros 

        public DataTable LeerTodos()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM catalogo_consolas";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los registros: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        //Funcion para agregar nuevo registro 
        public void Insertar (Usuario usr)
        {
            try
            {
                string query = "INSERT INTO catalogo_consolas ( nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@nombre_consola, @compania, @anio_lanzamiento, @generacion)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@nombre_consola", usr.nombre_consola);
                cmd.Parameters.AddWithValue("@compania", usr.compania);
                cmd.Parameters.AddWithValue("@anio_lanzamiento", usr.ano_de_lanzamiento);
                cmd.Parameters.AddWithValue("@generacion", usr.generacion);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro" + ex.Message);
            }
            finally
            {
                connection.Close(); 
            }
        }
        //Funcion para eleminar un registro 
        
        public void Eliminar_registro (Usuario usr)
        {
            try
            {
                string query = "DELETE FROM catalogo_consolas WHERE id_consola = @id_consola";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id_consola", usr.id_consola);

                connection.Open();
                cmd.ExecuteNonQuery();
                



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eleminar el registro" + ex.Message);
            } 

            finally
            {
                connection.Close();
            }
        }
        //Funcion para actulizar registro 
        public void Actualizar_registro(Usuario usr)
        {
            try
            {
                string query = "UPDATE catalogo_consolas SET nombre_consola = @nombre_consola, compania = @compania, anio_lanzamiento = @anio_lanzamiento, generacion = @generacion WHERE id_consola = @id_consola";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id_consola", usr.id_consola);
                cmd.Parameters.AddWithValue("@nombre_consola", usr.nombre_consola);
                cmd.Parameters.AddWithValue("@compania", usr.compania);
                cmd.Parameters.AddWithValue("@anio_lanzamiento", usr.ano_de_lanzamiento);
                cmd.Parameters.AddWithValue("@generacion", usr.generacion);

                connection.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        //Funcion para buscar por su numero de ID
        public DataRow LeerPorId(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM catalogo_consolas WHERE id_consola = @id_consola";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id_consola", id);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el registro: " + ex.Message);
                
            }
            finally
            {
                connection.Close();

            }
            return dt.Rows[0];

        }




    }

}

