using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tcc.SegurancaQA.Legado.Dto.Enumeradores;

namespace Tcc.SegurancaQA.Legado.Mvc.Models.Checklist
{
    public class ChecklistModel
    {
        public int Id { get; set; }
        public string Responsavel { get; set; }
        public string Area { get; set; }
        public string Status { get; set; }
        public string RealizadoEm { get; set; }
        public string Observacao { get; set; }
    }
}