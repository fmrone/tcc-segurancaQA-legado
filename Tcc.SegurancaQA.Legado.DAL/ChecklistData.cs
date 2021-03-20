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
using Tcc.SegurancaQA.Legado.Dto.Enumeradores;

namespace Tcc.SegurancaQA.Legado.Data
{
    public class ChecklistData
    {
        private readonly string _conexao = ConfigurationManager.ConnectionStrings["bd-tcc-indtextbr"].ConnectionString;

        public List<ChecklistDto> Listar()
        {
            using (IDbConnection con = new SqlConnection(_conexao))
            {
                var cmd = @"SELECT Id, Responsavel, Area, RealizadoEm, Observacao
                              FROM Checklist
                             ORDER BY Id";

                return con.Query<ChecklistDto>(cmd).ToList();
            }
        }

        public List<ChecklistDto> Listar(EArea area) 
        {
            using (IDbConnection con = new SqlConnection(_conexao)) 
            {
                var cmd = @"SELECT Id, Responsavel, Area, RealizadoEm, Observacao
                              FROM Checklist
                        WHERE Area = @area
                        ORDER BY Id";

                return con.Query<ChecklistDto>(cmd, new { area }).ToList();
            }
        }
    }
}
