using Laboratorio_de_curso.Data;
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
    }
}
