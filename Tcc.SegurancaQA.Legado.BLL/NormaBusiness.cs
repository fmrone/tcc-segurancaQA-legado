using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tcc.SegurancaQA.Legado.Data;
using Tcc.SegurancaQA.Legado.Dto;

namespace Tcc.SegurancaQA.Legado.Business
{
    public class NormaBusiness
    {
        private readonly NormaData _normaData;

        public NormaBusiness()
        {
            _normaData = new NormaData();
        }

        public List<NormaDto> Listar()
        {
            return _normaData.Listar();
        }
    }
}
