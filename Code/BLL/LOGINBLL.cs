using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonioGabriel3c1_02.Code.BLL
{
    class LOGINBLL
    {
        AcessoBD conexao = new AcessoBD();
        string tabela = "tbl_login";

        public bool RealizarLogin(LOGINDTO login)     
        {
            string sql = $"select * from {tabela} where email='{login.Email}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public string RetornarSenha(LOGINDTO login)     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} where email='{login.Email}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["senha"].ToString();
            else
                return "false";
        }

    }
}
    }
}
