using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using projetocinema.ConexaoBD;
namespace projetocinema.Modelo
{
    class Filme
    {
        private int intCodigo;

        public int IntCodigo
        {
            get { return intCodigo; }
            set { intCodigo = value; }
        }

        private string StrfNome;

        public string StrfNome1
        {
            get { return StrfNome; }
            set { StrfNome = value; }
        }

        private string StrfCategoria;

        public string StrfCategoria1
        {
            get { return StrfCategoria; }
            set { StrfCategoria = value; }
        }

        private int intDuracao;

        public int IntDuracao
        {
            get { return intDuracao; }
            set { intDuracao = value; }
        }

        private string StrPaisOrigem;

        public string StrPaisOrigem1
        {
            get { return StrPaisOrigem; }
            set { StrPaisOrigem = value; }
        }

        private string strClassificacao;

        public string StrClassificacao
        {
            get { return strClassificacao; }
            set { strClassificacao = value; }
        }
    
        private int intCodDiretor;

        public int IntCodDiretor
        {
            get { return intCodDiretor; }
            set { intCodDiretor = value; }
        }

        private int intAnoDirecao;

        public int IntAnoDirecao
        {
            get { return intAnoDirecao; }
            set { intAnoDirecao = value; }
        }

          public Filme(){
            //metodo construtor
        }

        public void salvar()
        {
           
            String SQl = "insert into filme(CodFilme,NomeFilme,Categoria,Duracao,Classificacao,PaisOrigem,CodigoDiretor,AnoDirecao)values(se_filmeS.nextval,'" + StrfNome + "','" + StrfCategoria + "'," + intDuracao + ",'" + StrClassificacao + "','" + StrPaisOrigem + "'," + intCodDiretor + "," + intAnoDirecao + ")";
            try{               
                int numTuplas = BancoOracle.GetInstancia().Persistir(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void alterar()
        {
            //instrucoes para alterar o objeto filme
            
            string SQl = "UPDATE filme set NomeFilme = '" + StrfNome + "',Categoria = '" + StrfCategoria + "',Duracao = " + intDuracao + ",Classificacao = '" + StrClassificacao + "',PaisOrigem = '" + StrPaisOrigem + "', CodigoDiretor= " + intCodDiretor + ",AnoDirecao = '" + intAnoDirecao + "' where CodFilme = " + intCodigo;
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
            //instrucoes para excluir o objeto filme
            string SQl = "Delete from filme where CodFilme = '" + intCodigo + "' ";

            try
            {
                int numTuplas = BancoOracle.GetInstancia().Persistir(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable recuperarTodosF()
        {

            string SQl = "Select CodFilme AS Código,NomeFilme AS Nome,Categoria AS Categoria,Duracao AS Duração_min,Classificacao AS Classificação,PaisOrigem AS País_de_Origem,CodigoDiretor As Diretor,AnoDirecao AS Ano from filme";
            //string SQl = "Select NomeFilme AS Nome,Categoria AS Categoria,Duracao AS Duração,Classificacao AS Classificação,PaisOrigem AS País_de_Origem,CodigoArtista as Artista,CodigoDiretor As Diretor from filme";
         
            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar todos os filmes cadastrados "
                    + ex.Message);
            }
        }

        public static DataTable recuperarTodosFiltroF(string filtro)
        {
            //instrucoes para consultar objetos do tipo filme"
          /*  string SQl = "SELECT CodFilme,NomeFilme,Categoria,Duracao,Classificacao,PaisOrigem,CodigoArtista,CodigoDiretor  from filme WHERE NomeFilme LIKE '%"
                + filtro + "%' ORDER BY NomeFilme";*/
            string SQl = "SELECT NomeFilme,Categoria,Duracao,Classificacao,PaisOrigem,CodigoDiretor,AnoDirecao from filme WHERE NomeFilme LIKE '%"
                + filtro + "%' ORDER BY NomeFilme";
            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar todos os filmes cadastrados "
                    + ex.Message);
            }
        }
      
        public static DataTable BuscaFilme(string PesFilme)
        {
            string SQl = "select f.NomeFilme as Filme,f.Categoria as Categoria,f.Classificacao as Classificação,f.PaisOrigem as Origem,d.NomeDiretor as Diretor,f.AnoDirecao as Ano,s.NumeroSala as Sala,s.DataExibicao as Exibição,to_char(s.Horario,'hh24:mi')Horário from filme f join diretor d on f.CodigoDiretor=d.IdDiretor join sessao s on s.CodigoFilme=f.CodFilme join cinema b on b.CodCinema=s.CodigoCinema where NomeCinema='"+PesFilme+"'";
          // string SQl = "select f.NomeFilme as Filme,f.Categoria as Categoria,f.Classificacao as Classificação,f.PaisOrigem as Origem,d.NomeDiretor as Diretor,f.AnoDirecao as Ano,s.NumeroSala as Sala,s.DataExibicao as Exibição,to_char(s.Horario,'hh24:mi')Horário from filme f join diretor d on f.CodigoDiretor=d.IdDiretor join sessao s on s.CodigoFilme=f.CodFilme join cinema b on b.CodCinema=s.CodigoCinema"; 

            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar dados dos Cinemas" + ex.Message);
            }
        }

        public static DataTable BuscaFilmeRelatorio()
        {          
             string SQl = "select f.NomeFilme as Filme,f.Categoria as Categoria,f.Classificacao as Classificação,f.PaisOrigem as Origem,d.NomeDiretor as Diretor,f.AnoDirecao as Ano,s.NumeroSala as Sala,s.DataExibicao as Exibição,to_char(s.Horario,'hh24:mi')Horário from filme f join diretor d on f.CodigoDiretor=d.IdDiretor join sessao s on s.CodigoFilme=f.CodFilme join cinema b on b.CodCinema=s.CodigoCinema"; 

            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar dados dos Cinemas" + ex.Message);
            }
        }   
    } 
}
