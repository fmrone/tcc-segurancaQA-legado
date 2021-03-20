using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tcc.SegurancaQA.Legado.Business;
using Tcc.SegurancaQA.Legado.Dto;
using Tcc.SegurancaQA.Legado.Mvc.Models.Checklist;

namespace Tcc.SegurancaQA.Legado.Mvc.Controllers
{
    public class ChecklistController : Controller
    {
        private readonly ChecklistBusiness _checklistBusiness;

        public ChecklistController()
        {
            _checklistBusiness = new ChecklistBusiness();
        }

        // GET: Cheklist
        public ActionResult Index()
        {
            var checklistsDto = _checklistBusiness.Listar();
            var checklistsModel = MapeiaListaDtoParaListaModel(checklistsDto);

            return View(checklistsModel);
        }

        public ActionResult Normas(int checklistId) 
        {
            var checklistNormasDto = _checklistBusiness.ListarCheklistNormas(checklistId);
            var checklistNormasModel = MapeiaListaDtoParaListaModel(checklistNormasDto);

            return View(checklistNormasModel);
        }

        private List<ChecklistModel> MapeiaListaDtoParaListaModel(List<ChecklistDto> checklistsDto) 
        {
            var checklistsModel = new List<ChecklistModel>();
            foreach (var item in checklistsDto)
            {
                checklistsModel.Add(new ChecklistModel
                {
                    Id = item.Id,
                    Responsavel = item.Responsavel,
                    Area = item.Area == Dto.Enumeradores.EArea.Ambiental ? "Ambiental" : "Industrial",
                    Status = (item.RealizadoEm == DateTime.MinValue || item.RealizadoEm == null) ? "<span class='label label-danger'>aberto</span>" : "<span class='label label-success'>finalizado</span>",
                    RealizadoEm = (item.RealizadoEm == DateTime.MinValue || item.RealizadoEm == null) ? "" : item.RealizadoEm.Value.ToString("dd/MM/yyyy HH:mm:ss"),
                    Observacao = item.Observacao
                });
            }
            return checklistsModel;
        }

        private List<ChecklistNormaModel> MapeiaListaDtoParaListaModel(List<ChecklistNormaDto> checklistNormasDto)
        {
            var checklistNormasModel = new List<ChecklistNormaModel>();
            foreach (var item in checklistNormasDto)
            {
                checklistNormasModel.Add(new ChecklistNormaModel
                {
                    ChecklistId = item.ChecklistId,
                    NormaId = item.NormaId,
                    CodigoNorma = item.CodigoNorma,
                    DescricaoNorma = item.DescricaoNorma,
                    NormaAtendida = item.Atendido
                });
            }
            return checklistNormasModel;
        }
    }
}