using AutoMapper;
using BancoStandard.EmprestimosAPI.Data.ValueObjects;
using BancoStandard.EmprestimosAPI.Model;
using BancoStandard.EmprestimosAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace BancoStandard.EmprestimosAPI.Repository
{
    public class ContractRepository : IContractRepository
    {
        private readonly SQLContext _context;
        private IMapper _mapper;

        public ContractRepository(SQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<IEnumerable<ContractVO>> FindAll()
        {
            List<Contract> contracts = await _context.Contracts.ToListAsync();
            return _mapper.Map<List<ContractVO>>(contracts);
        }

        public async Task<ContractVO> FindById(long id)
        {
            Contract contract = await _context.Contracts.Where(p => p.Id == id)
                .FirstOrDefaultAsync() ?? new Contract();
            return _mapper.Map<ContractVO>(contract);
        }
        public async Task<ContractVO> Create(ContractVO vo)
        {
            Contract contract = _mapper.Map<Contract>(vo);

            _context.Contracts.Add(contract);
            await _context.SaveChangesAsync();
            return _mapper.Map<ContractVO>(contract);
        }

        public async Task<ContractVO> Update(ContractVO vo)
        {
            Contract contract = _mapper.Map<Contract>(vo);

            _context.Contracts.Update(contract);
            await _context.SaveChangesAsync();
            return _mapper.Map<ContractVO>(contract);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Contract contract = await _context.Contracts.Where(p => p.Id == id)
                    .FirstOrDefaultAsync() ?? new Contract();
                if (contract.Id <= 0) return false;
                _context.Contracts.Remove(contract);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

     
    }
}
