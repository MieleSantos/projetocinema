using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using projetocinema.ConexaoBD;

namespace projetocinema.Modelo
{
    class Usuario
    {
        private int intUCodigo;

        public int IntUCodigo
        {
            get { return intUCodigo; }
            set { intUCodigo = value; }
        }

        private string strUNome;

        public string StrUNome
        {
            get { return strUNome; }
            set { strUNome = value; }
        }

        private string strEmail;

        public string StrEmail
        {
            get { return strEmail; }
            set { strEmail = value; }
        }

        public Usuario()
        {

        }

        public void salvar()
        {
            
            String SQl = "insert into cliente(IdCliente,NomeCliente,Email)values(se_clienteS.NEXTVAL,'" + strUNome + "','" + strEmail + "')";
            try
            {
                int numTuplas = BancoOracle.GetInstancia().Persistir(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void alterar()
        {
          
            string SQl = "UPDATE cliente  SET  NomeCliente = '" + strUNome + "', Email = '" + strEmail + "' WHERE  IdCliente = " + intUCodigo;

            try
            {
                int numTuplas = BancoOracle.GetInstancia().Persistir(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void excluir()
        {
            
            string SQl = "Delete from cliente where IdCliente = " + intUCodigo;

            try
            {
                int numTuplas = BancoOracle.GetInstancia().Persistir(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable recuperarTodos(string strANome)
        {
            //string SQl = "Select IDCliente AS Código,NomeCliente AS Nome,Email AS Email from cliente where NomeCliente ='"+strANome+"' ";
            string SQl = "Select IDCliente AS Código,NomeCliente AS Nome,Email AS Email from cliente where NomeCliente ='" + strANome + "' ";

            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar todos os alunos cadastrados "
                    + ex.Message);
            }
        }

        public static DataTable recuperarTodosUsuarios()
        {

            string SQl = "Select IdCliente as Código,NomeCliente AS Nome,Email AS Email from cliente;";

            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar todos os alunos cadastrados "
                    + ex.Message);
            }
        }

        public static DataTable recuperarTodosFiltro(string filtro)
        {
            
           /* string SQl = "SELECT IdCliente as Código, NomeCliente as Nome, EMAIL as Email FROM cliente WHERE NomeCliente LIKE '%"
                + filtro + "%' ORDER BY NomeCliente";*/
             string SQl = "SELECT IdCliente as ID, NomeCliente as Nome, EMAIL as Email FROM cliente WHERE EMAIL = '"+filtro+"'";
            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar todos os alunos cadastrados "
                    + ex.Message);
            }
        } 
    }
}

 