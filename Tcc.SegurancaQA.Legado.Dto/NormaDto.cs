using System;
using System.Collections.Generic;
using System.Text;
using Tcc.SegurancaQA.Legado.Dto.Enumeradores;

namespace Tcc.SegurancaQA.Legado.Dto
{
    public class NormaDto
    {
        public int Id { get; set; }//PK
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public EArea Area { get; set; }
        public bool Status { get; set; }

        //utilizado nas integrações
        public DateTime? IntegradoEm { get; set; }
        public string Integracao { get; set; }
    }
}
