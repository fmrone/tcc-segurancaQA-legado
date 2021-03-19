using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.SegurancaQA.Legado.Dto
{
    public class ChecklistNormaDto
    {
        public int ChecklistId { get; set; }//PKFK
        public int NormaId { get; set; }//PKFK
        public bool? Atendido { get; set; }
    }
}
