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
    public class ChecklistNormaData
    {
        private readonly string _conexao = ConfigurationManager.ConnectionStrings["bd-tcc-indtextbr"].ConnectionString;

        public List<ChecklistNormaDto> Listar(int checklistId)
        {
            using (IDbConnection con = new SqlConnection(_conexao))
            {
                var cmd = @"SELECT cn.ChecklistId, cn.NormaId, cn.Atendido,
                                   n.Codigo AS CodigoNorma, n.Descricao AS DescricaoNorma, n.Status AS StatusNorma
                              FROM ChecklistNorma cn
                                   INNER JOIN Checklist c ON (cn.ChecklistId = c.Id)
                                   INNER JOIN Norma n ON(cn.NormaId = n.Id)
                             WHERE c.Id = @checklistId";

                return con.Query<ChecklistNormaDto>(cmd, new { checklistId }).ToList();
            }
        }
    }
}
