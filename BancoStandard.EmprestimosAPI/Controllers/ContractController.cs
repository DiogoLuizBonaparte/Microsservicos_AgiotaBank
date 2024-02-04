﻿using BancoStandard.EmprestimosAPI.Data.ValueObjects;
using BancoStandard.EmprestimosAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoStandard.EmprestimosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private IContractRepository _repository;
        public ContractController(IContractRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));                
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContractVO>>> FindAll()
        {
            var contracts = await _repository.FindAll();           
            return Ok(contracts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContractVO>> FindById(long id)
        {
            var contract = await _repository.FindById(id);
            if (contract == null) return NotFound();
            return Ok(contract);
        }
    }
}