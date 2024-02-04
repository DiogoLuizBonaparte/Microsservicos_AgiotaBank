using BancoStandard.Front.Models;
using BancoStandard.Front.Services;
using BancoStandard.Front.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BancoStandard.Front.Controllers
{
    public class ContractController : Controller
    {
        private readonly IContractService _contractservice;
        public ContractController(IContractService contractservice)
        {
             _contractservice = contractservice ?? throw new ArgumentNullException(nameof(contractservice));
        }
        public async Task<IActionResult> ContractIndex()
        {
            var contracts = await _contractservice.FindAllContracts();
            return View(contracts);
        }
        public async Task<IActionResult> ContractCreate()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ContractCreate(ContractModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _contractservice.CreateContract(model);
                if (response != null) return RedirectToAction(nameof(ContractIndex));

            }

            return View(model);
        }
        public async Task<IActionResult> ContractUpdate(long id)
        {
            var model = await _contractservice.FindContractById(id);
            if (model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ContractUpdate(ContractModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _contractservice.UpdateContract (model);
                if (response != null) return RedirectToAction(nameof(ContractIndex));

            }

            return View(model);
        }

        public async Task<IActionResult> ContracttDelete(long id)
        {
            var model = await _contractservice.FindContractById(id);
            if (model != null) return View(model);
            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> ContractDelete(ClientModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _contractservice.DeleteContractById(model.Id);
                if (response) return RedirectToAction(nameof(ContractIndex));

            }
            return View(model);
        }
    }
}
