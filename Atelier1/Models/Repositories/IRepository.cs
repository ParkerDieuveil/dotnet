namespace Atelier1.Models.Repositories
{
    public interface IRepository<T>
    {
        IList<T> GetAll();
        List<T> Search(string term);
        T FindByID(int id);
        void Add(T entity);
        void Update(int id, T entity);
        void Delete(int id);

        double SalaryAverage();
        double MaxSalary();
        int HrEmployeesCount();
        List<string> DepartAll();

    }
}
