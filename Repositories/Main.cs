using System.Threading.Tasks;
using System;

public class Main<T> : IRepository<T> where T : EntityBase
{
    public T GetById(Guid Id)
    {
        throw new NotImplementedException();
    }
    public async Task Create(T entity)
    {
        throw new NotImplementedException();
    }
    public async Task Update(T entity)
    {
        throw new NotImplementedException();
    }
    public async Task Delete(T entity)
    {
        throw new NotImplementedException();
    }
}