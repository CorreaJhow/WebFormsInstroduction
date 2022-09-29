using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    public class PessoaRepository
    {
        SqlConnection conn;
        public PessoaRepository()
        {
            conn = ConnectionSQL.GetConnection();
            conn.Open();
            //receber a conexão.
        }
        public bool Insert(Pessoa pessoa)
        {
            //implementação da inclusão dos dados. 
            //Exemplo Insert
            string strInsert = "insert into Pessoa (Id, Nome, Telefone) values (@Id, @Nome, @Telefone)";
            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@Id", pessoa.Id));
            commandInsert.Parameters.Add(new SqlParameter("@Nome", pessoa.Nome));
            commandInsert.Parameters.Add(new SqlParameter("@Telefone", pessoa.Telefone));

            //insere no banco
            commandInsert.ExecuteNonQuery();
            return true;
        }
    }
}
