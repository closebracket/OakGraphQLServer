using System;

public interface IRepository<T> where T : EntityBase
{
    T GetById(Guid id);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}