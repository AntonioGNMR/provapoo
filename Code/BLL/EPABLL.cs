using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AntonioGabriel3c1_02.Code.DTO;

namespace AntonioGabriel3c1_02.Code.BLL
{
    class EPABLL
    {
        AcessoBD conexao = new AcessoBD();
        string tabela = "tbl_epa";

        public void inserir(EPADTO ePADTO)
        {
            string inserir = $"insert into {tabela} values(null,'{ePADTO.Produto}','{ePADTO.Descricao}')";
            conexao.ExecutarComando(inserir);
        }
        public DataTable Listar()     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(EPADTO ePADTO)
        {
            string alterar = $"update {tabela} set produto = '{ePADTO.Produto}', descricao = '{ePADTO.Descricao}' where id = '{ePADTO.Id}';";
            conexao.ExecutarComando(alterar);
        }
        public void Excluir(EPADTO ePADTO)
        {
            string excluir = $"delete from {tabela} where id = '{ePADTO.Id}';";
            conexao.ExecutarComando(excluir);
        }
    }
}
