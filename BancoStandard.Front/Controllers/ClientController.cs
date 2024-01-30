using BancoStandard.Front.Models;
using BancoStandard.Front.Services.IServices;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> ClientCreate(ClientModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _clientService.CreateClient(model);
                if (Response != null) return RedirectToAction(nameof(ClientIndex));
                
            }
                return View(model);
        }
    }   
}
