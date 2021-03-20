using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.SegurancaQA.Legado.Dto
{
    public class ChecklistNormaDto
    {
        public int ChecklistId { get; set; }
        public int NormaId { get; set; }
        public bool? Atendido { get; set; }

        #region Norma
        public string CodigoNorma { get; set; }
        public string DescricaoNorma  { get; set; }
        public bool? StatusNorma { get; set; }
        #endregion
    }
}
