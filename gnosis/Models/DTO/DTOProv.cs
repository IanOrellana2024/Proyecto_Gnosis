using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnosis.Models.DTO
{
    internal class DTOProv : dbContext
    {
        private int id;

        public int Id { get => id; set => id = value; }

        private string buscar;

        public string Buscar1 { get => buscar; set => buscar = value; }
    }
}
