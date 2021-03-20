using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tcc.SegurancaQA.Legado.Dto;

namespace Tcc.SegurancaQA.Legado.Data
{
    public class NormaData
    {
        private readonly string _conexao = ConfigurationManager.ConnectionStrings["bd-tcc-indtextbr"].ConnectionString;

        public List<NormaDto> Listar() 
        {
            using (IDbConnection con = new SqlConnection(_conexao))
            {
                var cmd = @"SELECT Id, Codigo, Descricao, Area, [Status], IntegradoEm, Integracao
                              FROM Norma
                             ORDER BY Id, Area";

                return con.Query<NormaDto>(cmd).ToList();
            }
        }
    }
}
