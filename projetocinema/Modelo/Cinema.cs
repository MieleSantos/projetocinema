using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using projetocinema.ConexaoBD;

namespace projetocinema.Modelo
{
    class Cinema
    {
        private int intCodigo;

        public int IntCodigo
        {
            get { return intCodigo; }
            set { intCodigo = value; }
        }

        private string strNome;

        public string StrNome
        {
            get { return strNome; }
            set { strNome = value; }
        }

        private string strRua;

        public string StrRua
        {
            get { return strRua; }
            set { strRua = value; }
        }  

        private int intNumero;

        public int IntNumero
        {
            get { return intNumero; }
            set { intNumero = value; }
        }

        private string strBairro;

        public string StrBairro
        {
            get { return strBairro; }
            set { strBairro = value; }
        }
    
        private string strCidade;

        public string StrCidade
        {
            get { return strCidade; }
            set { strCidade = value; }
        }

        private string strEstado;

        public string StrEstado
        {
            get { return strEstado; }
            set { strEstado = value; }
        }

          public Cinema(){
            //metodo construtor
        }

        public void salvar()
        {
            String SQl = "insert into cinema(CodCinema,NomeCinema,Logradouro,Bairro,Numero,Cidade,Estado)values(se_cinemaS.nextval,'" + strNome + "','" + strRua + "','" + strBairro + "','" + intNumero + "','" + strCidade + "','" + strEstado + "')";
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
            //instrucoes para alterar o objeto Cinema
            string SQl = "Update cinema set NomeCinema ='" + strNome + "',Logradouro ='" + strRua + "',Bairro = '" + strBairro + "',Numero ='" + intNumero + "',Cidade ='" + strCidade + "',Estado = '" + strEstado + "' where CodCinema = '" + intCodigo + "' ";
            try
            {
                BancoOracle.GetInstancia().Persistir(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void excluir()
        {
            
            string SQl = "Delete from cinema where  CodCinema = " + intCodigo;

            try
            {
                BancoOracle.GetInstancia().Persistir(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static DataTable recuperarTodos()
        {   

            string SQl = "Select CodCinema AS Código,NomeCinema AS Nome,Logradouro AS Rua,Bairro AS Bairro,Numero AS Número,Cidade AS Cidade,Estado AS Estado from cinema";

            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar todos os cinemas cadastrados "
                    + ex.Message);
            }
        }
       
        public static DataTable recuperarTodosCinemas(string strPesquisaCinema)
        {
            
            string SQl = "Select NomeCinema AS Nome,Logradouro AS Rua,Bairro AS Bairro,Numero AS Número,Cidade AS Cidade,Estado AS Estado from cinema where Cidade = '"+strPesquisaCinema+"'";
                  
            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar todos os cinemas cadastrados "
                    + ex.Message);
            }                 
        }
        public static DataTable recuperarTodoasCidades()
        {

            string SQl = "Select distinct cidade from cinema";

            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar todos os cinemas cadastrados "
                    + ex.Message);
            }
        }


        public static DataTable recuperarTodosFiltro(string filtro)
        {
            
            string SQl = "SELECT CodCinema,NomeCinema,Logradouro,Bairro,Numero,Cidade,Estado FROM cinema WHERE NomeCinema LIKE '%"
                + filtro + "%' ORDER BY NomeCinema";
            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar todos os cinemas cadastrados "
                    + ex.Message);
            }
        }

    }
}
