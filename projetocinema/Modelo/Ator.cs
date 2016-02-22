using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using projetocinema.ConexaoBD;

namespace projetocinema.Modelo
{
    class Ator
    {
        private int intCodigoA;

        public int IntCodigoA
        {
            get { return intCodigoA; }
            set { intCodigoA = value; }
        }

        private string strNome;

        public string StrNome
        {
            get { return strNome; }
            set { strNome = value; }
        }
        
        public Ator()
        {

        }
      
        public void salvar()
        {

            String SQl = "insert into artista(CodArtista,NomeArtista )values(se_artistaS.nextval,'" + strNome  + "')";
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
           
            string SQl = "UPDATE artista  SET NomeArtista = '"+strNome+"' where CodArtista = '"+ intCodigoA+"' ";

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
            string SQl = "Delete from artista where CodArtista = '"+IntCodigoA+"' ";

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

            string SQl = "Select CodArtista AS Id_Artista,NomeArtista AS Artista from artista";
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

        public static DataTable recuperarTodosFiltro(string filtro)
        {
            
            string SQl = "SELECT CodArtista,NomeArtista from artista WHERE NomeArtista LIKE '%"
                + filtro + "%' ORDER BY NomeArtista";
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
