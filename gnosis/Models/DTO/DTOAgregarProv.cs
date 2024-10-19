using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnosis.Models.DTO
{
    internal class DTOAgregarProv : dbContext
    {
        private string nombre;
        private string telefono;
        private string direccion;
        private string correo;
        private string codigo;
        private int estado;
        private string comentario;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Comentario { get => comentario; set => comentario = value; }
    }
}
