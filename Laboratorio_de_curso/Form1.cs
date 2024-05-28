using Laboratorio_de_curso.Data;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_de_curso
{
    public partial class Form1 : Form
    {
        private ConexionMysql registros_consolas;
        ConexionMysql clscone = new ConexionMysql();
        Usuario usr = new Usuario();
        public Form1()
        {
            InitializeComponent();
            registros_consolas = new ConexionMysql();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Boton de cargar base de datos
        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = registros_consolas.LeerTodos();
            dataGridView_Consolas.DataSource = dt;
        }

        //Boton para crear nuevo registro
        private void button1_Click(object sender, EventArgs e)
        {
            usr.nombre_consola = Nombre_de_Consola.Text;
            usr.compania = Compania.Text;
            usr.ano_de_lanzamiento = Ano_lanzamiento.Value;
            usr.generacion = int.Parse(Generacion_numeric.Text);
            clscone.Insertar (usr);

            MessageBox.Show("Registro creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Nombre_de_Consola.Clear();

            DataTable dt = registros_consolas.LeerTodos();
            dataGridView_Consolas.DataSource = dt;

        }
        //Boton para borrar registro 
        private void button2_Click(object sender, EventArgs e)
        {
            usr.id_consola = int.Parse (ID_Consola.Text);
            clscone.Eliminar_registro(usr);

            MessageBox.Show("Se elimino el registro correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information );

            DataTable dt = registros_consolas.LeerTodos();
            dataGridView_Consolas.DataSource = dt;
        }

        private void ID_Consola_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
