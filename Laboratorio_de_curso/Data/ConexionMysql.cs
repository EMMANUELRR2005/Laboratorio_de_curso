using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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


    }

 }

