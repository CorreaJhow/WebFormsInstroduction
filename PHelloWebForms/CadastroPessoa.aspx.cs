using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Service;

namespace PHelloWebForms
{
    public partial class CadastroPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string statusRetorno = "";
            Pessoa p = new Pessoa()
            {
                Id = int.Parse(TxtId.Text),
                Nome = TxtNome.Text,
                Telefone = TxtTelefone.Text
            };

            if (new PessoaService().Insert(p))
                statusRetorno = "Registro Inserido com sucesso";
            else 
                statusRetorno = "Erro ao inserir registro";

            Lblmsg.Text = statusRetorno;
        }
    }
}