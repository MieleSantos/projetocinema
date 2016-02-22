using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using projetocinema.ConexaoBD;

namespace projetocinema.Modelo
{
    class Sessao
    {
        private int intNumeroSessao;

        public int IntNumeroSessao
        {
            get { return intNumeroSessao; }
            set { intNumeroSessao = value; }
        }

        private DateTime dtDataExibicao;

        public DateTime DtDataExibicao
        {
            get { return dtDataExibicao; }
            set { dtDataExibicao = value; }
        }

        private DateTime dthorario;

        public DateTime Dthorario
        {
            get { return dthorario; }
            set { dthorario = value; }
        }

        private int intIdFilme;

        public int IntIdFilme
        {
            get { return intIdFilme; }
            set { intIdFilme = value; }
        }

        private int intCodigoSala;

        public int IntCodigoSala
        {
            get { return intCodigoSala; }
            set { intCodigoSala = value; }
        }

        public Sessao()
        {

        }
        public void salvar()
        {
            string data = dtDataExibicao.ToShortDateString();
            string hora = dthorario.ToShortTimeString();

            String SQL = "insert into sessao(NumeroSala,DataExibicao,Horario,CodigoFilme,CodigoCinema)values(se_sessaoS.nextval,to_date('" + data + "','dd/mm/yyyy hh24:mi'),to_date('" + data + "''" + hora + "','dd/mm/yyyy hh24:mi'),'" + intIdFilme + "',"+intCodigoSala+")";
                                        
            try
            {
                int numTuplas = BancoOracle.GetInstancia().Persistir(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void alterar()
        {
            string data = dtDataExibicao.ToShortDateString();
            string hora = dthorario.ToShortTimeString();

            string SQl = "Update sessao set DataExibicao = to_date('" + data + "','dd/mm/yyyy hh24:mi'),Horario = to_date('" + data + "''" + hora + "','dd/mm/yyyy hh24:mi'),CodigoFilme =" + intIdFilme + ",CodigoCinema = "+intCodigoSala+" where   NumeroSala = " + intNumeroSessao;

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
            int num = intNumeroSessao;

           string SQl = "Delete from sessao where NumeroSala = " +num;

           try
           {
               BancoOracle.GetInstancia().Persistir(SQl);
              
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
        }

        public static DataTable recuperarTodosS() 
        {
            string SQl = "Select CodigoFilme,NomeFilme as Filme,NumeroSala AS Sala,DataExibicao AS Exibição,to_char( Horario,'hh24:mi')Horário,CodigoCinema AS Codigo,NomeCinema as Cinema from sessao join filme on CodFilme=CodigoFilme join cinema on CodigoCinema=CodCinema";

            try
            {
                return BancoOracle.GetInstancia().Consultar(SQl);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar todos as sessões cadastradas "
                    + ex.Message);
            }
        }
    }
}
