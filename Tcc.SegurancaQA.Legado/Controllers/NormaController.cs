using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tcc.SegurancaQA.Legado.Business;
using Tcc.SegurancaQA.Legado.Dto;
using Tcc.SegurancaQA.Legado.Mvc.Models.Norma;

namespace Tcc.SegurancaQA.Legado.Mvc.Controllers
{
    public class NormaController : Controller
    {
        private readonly NormaBusiness _normaBusiness;
        
        public NormaController()
        {
            _normaBusiness = new NormaBusiness();
        }

        // GET: Norma
        public ActionResult Index()
        {
            var normasDto = _normaBusiness.Listar();
            var normasModel = MapeiaListaDtoParaListaModel(normasDto);

            return View(normasModel);
        }

        private List<NormaModel> MapeiaListaDtoParaListaModel(List<NormaDto> normasDto)
        {
            var normasModel = new List<NormaModel>();
            foreach (var item in normasDto)
            {
                normasModel.Add(new NormaModel
                {
                    Id = item.Id,
                    Codigo = item.Codigo,
                    Area = item.Area == Dto.Enumeradores.EArea.Ambiental ? "Ambiental" : "Industrial",
                    Descricao = item.Descricao,
                    Status = (item.Status == false) ? "<span class='label label-danger'>inativa</span>" : "<span class='label label-success'>ativa</span>",
                    IntegradoEm = (item.IntegradoEm == DateTime.MinValue || item.IntegradoEm == null) ? "" : item.IntegradoEm.Value.ToString("dd/MM/yyyy HH:mm:ss"),
                    Integracao = item.Integracao
                });
            }
            return normasModel;
        }
    }
}