using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tcc.SegurancaQA.Legado.Mvc.Models.Norma
{
    public class NormaModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Area { get; set; }
        public string Status { get; set; }
        public string IntegradoEm { get; set; }
        public string Integracao { get; set; }
    }
}