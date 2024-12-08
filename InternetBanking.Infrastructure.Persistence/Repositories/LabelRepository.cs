using InternetBanking.Core.Application.Interfaces.Repositories;
using InternetBanking.Core.Domain.Entities;
using InternetBanking.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace InternetBanking.Infrastructure.Persistence.Repositories
{
    public class LabelRepository : GenericRepository<Labels>, ILabelsRepository
    {
        private readonly ApplicationContext _dbContext;

        public LabelRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Labels>> GetAllLabelsAsync()
        {
            return await _dbContext.Labels.ToListAsync();                 
        }    
    }
}
