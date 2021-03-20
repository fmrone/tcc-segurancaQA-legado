using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tcc.SegurancaQA.Legado.Mvc.Models.Checklist
{
    public class ChecklistNormaModel
    {
        public int ChecklistId { get; set; }
        public int NormaId { get; set; }
        
        [Display(Name = "Código")]
        public string CodigoNorma { get; set; }
        [Display(Name = "Descrição")]
        public string DescricaoNorma { get; set; }
        [Display(Name = "Atendido?")]
        public bool? NormaAtendida { get; set; }
    }
}