using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonioGabriel3c1_02.Code.DTO
{
    class EPADTO
    {

        private int _id;
        private string _produto;
        private string _descricao;

        public int Id { get => _id; set => _id = value; }
        public string Produto { get => _produto; set => _produto = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
    }
}
