using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_de_curso.Data
{
    internal class Usuario
    {
        //Objeto para nuevo registro
        public int id_consola {  get; set; }
        public string nombre_consola { get; set; }
        public string compania { get; set; }
        public DateTime ano_de_lanzamiento { get; set; }
        public int generacion {  get; set; }

        public Usuario () { }
        public Usuario (int id_consola1, string nombre_consola1, string compnia1, DateTime ano_de_lanzamiento1, int generacion1)
        {
            id_consola = id_consola1;
            nombre_consola = nombre_consola1;
            compania = compnia1;
            ano_de_lanzamiento = ano_de_lanzamiento1;
            generacion = generacion1;
        }
    }
}
