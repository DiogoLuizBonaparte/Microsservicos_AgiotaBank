using AutoMapper;
using BancoStandard.CadastroAPI.Data.ValueObjects;
using BancoStandard.ClientAPI.Model;
using BancoStandard.ClientAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace BancoStandard.CadastroAPI.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SQLContext _context;
        private IMapper _mapper;
        public ClienteRepository(SQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ClienteVO>> FindAll()
        {
            List<Cliente> products = await _context.Clientes.ToListAsync();
            return _mapper.Map<List<ClienteVO>>(products);
        }
        public async Task<ClienteVO> FindById(long id)
        {
            Cliente product = await _context.Clientes.Where(p => p.Id == id)
                .FirstOrDefaultAsync() ?? new Cliente();
            return _mapper.Map<ClienteVO>(product);
        }

        public async Task<ClienteVO> Create(ClienteVO vo)
        {
            Cliente cliente = _mapper.Map<Cliente>(vo);

            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return _mapper.Map<ClienteVO>(cliente);
        }
        public async Task<ClienteVO> Update(ClienteVO vo)
        {
            Cliente cliente = _mapper.Map<Cliente>(vo);

            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
            return _mapper.Map<ClienteVO>(cliente);
        }
        public async Task<bool> Delete(long id)
        {
            try
            {
                Cliente cliente = await _context.Clientes.Where(p => p.Id == id)
                    .FirstOrDefaultAsync() ?? new Cliente();
                if (cliente.Id <= 0) return false;
                _context.Clientes.Remove(cliente);
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
