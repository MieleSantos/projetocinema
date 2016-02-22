using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using projetocinema.ConexaoBD;
using projetocinema.Modelo;

namespace projetocinema.Modelo
{
    class Atuacao
    {
       
        private int intCodigoFilme;

        public int IntCodigoFilme
        {
            get { return intCodigoFilme; }
            set { intCodigoFilme = value; }
        }

        private int intCodigoArtista;

        public int IntCodigoArtista
        {
            get { return intCodigoArtista; }
            set { intCodigoArtista = value; }
        }

        

        public Atuacao()
        {
    
    
         }

        public void salva()
        {
            String SQl = "insert into AtuaEm(Codigo_filme,IdArtista)values(" + intCodigoFilme + "," + intCodigoArtista + ")";
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

            string SQl = "update atuaEM set Codigo_filme = " + intCodigoFilme + ",IdArtista = " + intCodigoArtista + " where Codigo_filme  =" + intCodigoFilme;
            
            try
            {
                int numTuplas = BancoOracle.GetInstancia().Persistir(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public bool excluir()
        {

            String SQL = "delete from AtuaEm WHERE Codigo_filme = " + intCodigoFilme;

            try
            {
                BancoOracle.GetInstancia().Persistir(SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static DataTable RecuperarTodosA()
        {

          //  string SQL = "select   IDAtuacao,codigo_Filme as IdFilme,IdArtista as IDArtista, NomeFilme as Filme, NomeArtista as Artista,AnoAtuacao as Atuacao from AtuaEm,filme,artista where Codigo_Filme = CodFilme and IdArtista= CodArtista";
            string SQL = "select Codigo_Filme as Código, NomeFilme as Filme, NomeArtista as Artista from AtuaEm,filme,artista where Codigo_Filme = CodFilme and IdArtista= CodArtista";

            try
            {
                return BancoOracle.GetInstancia().Consultar(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar todas atuações cadastrados "
                    + ex.Message);
            }
        }

        public static DataTable recuperarTodosFiltroAtuacao(string filtro)
        {

            string SQl = "select Codigo_Filme as Código, NomeFilme as Filme, NomeArtista as Artista from AtuaEm join filme  on  Codigo_Filme = CodFilme join artista on IdArtista= CodArtista where NomeFilme  like '%"
                + filtro + "%' ORDER BY NomeFilme";
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
