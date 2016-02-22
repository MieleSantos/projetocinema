using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using projetocinema.ConexaoBD;

namespace projetocinema.Modelo
{
    class Pesquisa
    {
        private string strNomeCinema;

        public string StrNomeCinema
        {
            get { return strNomeCinema; }
            set { strNomeCinema = value; }
        }

        private string strCidadeCinema;

        public string StrCidadeCinema
        {
           get { return strCidadeCinema; }
           set { strCidadeCinema = value; }
        }

        private string strNomeFilme;

        public string StrNomeFilme
        {
            get { return strNomeFilme; }
            set { strNomeFilme = value; }
        }

        private string strPaisOrigemfilme;

        public string StrPaisOrigemfilme
        {
            get { return strPaisOrigemfilme; }
            set { strPaisOrigemfilme = value; }
        }


        private string strCategoriaPesquisa;

        public string StrCategoriaPesquisa
        {
            get { return strCategoriaPesquisa; }
            set { strCategoriaPesquisa = value; }
        }

   
        public Pesquisa()
        {
                      
        }



        public  DataTable buscaCinema()
        {
            string SQl = "select NomeCinema as Cinema,Logradouro as Rua,Bairro,Numero,Cidade,Estado from cinema where Cidade = '" + strNomeCinema + "'";
          
            
            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar dados dos Cinemas"+ ex.Message);
            }
        }
        public static DataTable BuscaFilme() 
        {
            string SQl = "select f.NomeFilme as filme,f.Categoria,f.Classificacao,f.PaisOrigem,d.NomeDiretor as diretor,f.AnoDirecao,s.NumeroSala as Sala from filme f,diretor d,sessao s,cinema t where f.CodigoDiretor = d.IdDiretor and s.CodigoFilme=f.CodFilme and t.CodigoSala=s.NumeroSala";

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
