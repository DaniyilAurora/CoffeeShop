using CoffeeShop.Entities;

public interface IContext<T> where T : CoffeeSale
{
    void Create(T entity);

    void Update(T entity);

    void Delete(Guid id);

    void Delete(T entity);

    IEnumerable<T> GetAll();
}