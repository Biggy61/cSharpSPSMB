﻿namespace InterfacesExample;

public interface IRepository<T> where T : IModel
{
    CarModel Get(Guid Id);
    List<T> Get();
    void Insert(T model);
    void Update(T model);
    void Delete(Guid Id);
    int RecordCount();
}