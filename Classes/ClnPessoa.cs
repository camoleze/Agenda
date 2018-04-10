using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes
{
    class ClnPessoa
    {
        string comando;
        public string nome { get; set; }
        public string apelido { get; set; }
        public string  fone { get; set; }
        public long celular { get; set; }
        public string email { get; set; }
        public int cod_profissional { get; set; }
        clnConexao conecta = new clnConexao();
        public string inserir()
        {
            string msg;
            //COMANDO SQL PARA INSERIR
            comando = "INSERT INTO CADASTRO_PESSOA ";
            comando += "(NOME, APELIDO, FONE, CELULAR, EMAIL, COD_PROFISSIONAL)";
            comando += " VALUES ";
            comando += "('" + nome + "',";
            comando += "'" + apelido + "',";
            comando += "'" + fone + "',";
            comando += celular + ",";
            comando += "'" + email + "',";
            comando += +cod_profissional+ ")";
            int i=conecta.ExecutarComando(comando);
            if (i > 0)
            {
               return msg = "Dados inseridos com sucesso!";
            } else return msg = "Erro ao gravar os dados";
        }

    }
}
