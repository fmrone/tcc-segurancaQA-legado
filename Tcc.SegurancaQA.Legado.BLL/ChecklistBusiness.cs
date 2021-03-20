using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tcc.SegurancaQA.Legado.Data;
using Tcc.SegurancaQA.Legado.Dto;
using Tcc.SegurancaQA.Legado.Dto.Enumeradores;

namespace Tcc.SegurancaQA.Legado.Business
{
    public class ChecklistBusiness
    {
        private readonly ChecklistData _checklistData;
        private readonly ChecklistNormaData _checklistNormaData;

        public ChecklistBusiness() 
        {
            _checklistData = new ChecklistData();
            _checklistNormaData = new ChecklistNormaData();
        }

        public List<ChecklistDto> Listar()
        {
            return _checklistData.Listar();
        }

        public List<ChecklistDto> Listar(EArea area)
        {
            return _checklistData.Listar(area);
        }

        public List<ChecklistNormaDto> ListarCheklistNormas(int checklistId)
        {
            return _checklistNormaData.Listar(checklistId);
        }
    }
}
