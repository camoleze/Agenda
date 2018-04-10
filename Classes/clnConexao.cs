using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes
{
    class clnConexao
    {
        public static SqlConnection AbreBanco()
        {
           // string StringConexao = "Data Source=.; Initial Catalog==Agenda ;User id=Fulano_123; Password=123456;";
            string StringConexao="Data Source=.; Initial Catalog=AGENDA; User Id=Fulano_123; Password=123456;";
            try
            {
                SqlConnection conn =new SqlConnection(StringConexao);
                conn.Open();
                return conn;

            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FechaBanco(SqlConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable RetornaTabela(string strquery)
        {
            try
            {
            DataTable dt = new DataTable();
            SqlCommand cmdComando = new SqlCommand(strquery, AbreBanco());
            SqlDataAdapter da = new SqlDataAdapter(cmdComando);
            da.Fill(dt);
            return dt;
            }catch (Exception erro)
            {
                throw new Exception ("Erro de pesquisa da tabela "+ erro.Message);
            }
            finally
            {
                FechaBanco(AbreBanco());
            }
        }

        public SqlDataReader RetornaLinha(string strquery)
        {
            try
            {
                SqlDataReader dr;
                SqlCommand sqlcomando = new SqlCommand(strquery, AbreBanco());
                dr = sqlcomando.ExecuteReader();
                return dr;
            }catch (Exception erro)
            {
                throw new Exception("Erro de pesquisa da tabela " + erro.Message);
            }
            finally
            {
                FechaBanco(AbreBanco());
            }
        }

        public int ExecutarComando(string strquery)
        {
            try
            {
                SqlCommand sqlcomando = new SqlCommand(strquery, AbreBanco());
               return sqlcomando.ExecuteNonQuery();
            }catch (Exception erro)
            {
                throw new Exception("Erro ao executar comando" + erro.Message);
            }
            finally
            {
                FechaBanco(AbreBanco());
            }
        }
    }
}
