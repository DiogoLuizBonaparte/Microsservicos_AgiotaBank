using BancoStandard.Front.Models;
using BancoStandard.Front.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BancoStandard.Front.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService ?? throw new ArgumentNullException(nameof(clientService));
        }

        public async Task<IActionResult> ClientIndex()
        {
            var clients = await _clientService.FindAllClients();
            return View(clients);
        }
        public async Task<IActionResult> ClientCreate()
        {            
            return View();
        }

        [HttpPost]     
        public async Task<IActionResult> ClientCreate(ClientModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _clientService.CreateClient(model);
                if (response != null) return RedirectToAction(nameof(ClientIndex));
                
            }

                return View(model);
        }
        public async Task<IActionResult> ClientUpdate(long id)
        {
            var model = await _clientService.FindClientById(id);
            if (model != null)  return  View(model);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ClientUpdate(ClientModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _clientService.UpdateClient(model);
                if (response != null) return RedirectToAction(nameof(ClientIndex));

            }

            return View(model);
        }
        public async Task<IActionResult> ClientDelete(long id)
        {
            var model = await _clientService.FindClientById(id);
            if (model != null) return View(model);
            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> ClientDelete(ClientModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _clientService.DeleteClientById(model.Id);
                if (response) return RedirectToAction(nameof(ClientIndex));

            }

            return View(model);
        }
    }   
}
