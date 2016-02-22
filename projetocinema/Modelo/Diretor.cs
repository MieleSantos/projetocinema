using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using projetocinema.ConexaoBD;


namespace projetocinema.Modelo
{
    class Diretor
    {
        private int intCodDiretor;

        public int IntCodDiretor
        {
            get { return intCodDiretor; }
            set { intCodDiretor = value; }
        }

        private string strNome;

        public string StrNome
        {
            get { return strNome; }
            set { strNome = value; }
        }
       

        public Diretor()
        {

        }
      
        public void salvar()
        {

            String SQl = "insert into diretor(IdDiretor,NomeDiretor)values(se_diretorS.nextval,'" + strNome  + "')";
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
           
            string SQl = "UPDATE diretor  SET NomeDiretor = '"+strNome+"' where IdDiretor = '"+ intCodDiretor+"' ";

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
            string SQl = "Delete from diretor where IdDiretor = '"+intCodDiretor+"' ";

            try
            {
                int numTuplas = BancoOracle.GetInstancia().Persistir(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable recuperarTodos()
        {

            string SQl = "Select IdDiretor AS Código,NomeDiretor AS Diretor from diretor";
            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar todos os cadastrados "
                    + ex.Message);
            }
        }
   

        public static DataTable recuperarTodosFiltroD(string filtro)
        {

            string SQl = "SELECT IdDiretor,NomeDiretor from diretor WHERE NomeDiretor LIKE '%"
                + filtro + "%' ORDER BY NomeDiretor";
            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar todos os  cadastrados "
                    + ex.Message);
            }
        }
    }
}


