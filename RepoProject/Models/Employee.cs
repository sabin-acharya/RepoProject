namespace RepoProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public Nullable<decimal> sallary { get; set; }

        public string DeptId { get; set; }
    }
}
