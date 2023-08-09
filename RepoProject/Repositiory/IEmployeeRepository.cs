using RepoProject.Models;

namespace RepoProject.Repositiory
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int EmployeeId);

        void Insert(Employee employee);

        void Update(Employee employee);

        void Delete(int EmployeeId);

        void Save();
    }
}
