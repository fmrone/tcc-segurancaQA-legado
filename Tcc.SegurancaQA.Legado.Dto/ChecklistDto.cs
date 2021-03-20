using System;
using System.Collections.Generic;
using System.Text;
using Tcc.SegurancaQA.Legado.Dto.Enumeradores;

namespace Tcc.SegurancaQA.Legado.Dto
{
    public class ChecklistDto
    {
        public int Id { get; set; }//PK
        public string Responsavel { get; set; }
        public EArea Area { get; set; }
        public DateTime? RealizadoEm { get; set; }
        public string Observacao { get; set; }
    }
}
