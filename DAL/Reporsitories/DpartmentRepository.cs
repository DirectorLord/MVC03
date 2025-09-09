using DAL.Context.Configurations;
using DAL.Entities;

namespace DAL.Reporsitories;

public class deparmentRepository
{
    private CompanyDBContext _dbContext;

    public deparmentRepository()
    {
    }

    public deparmentRepository(CompanyDBContext dbContext)
    {
        _dbContext = dbContext;
    }
}
