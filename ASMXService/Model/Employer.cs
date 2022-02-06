namespace ASMXService.Model
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Department_Id { get; set; }
        public Employer(int id, string name, string lastName, int department_Id)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Department_Id = department_Id;
        }
        public Employer()
        {

        }
    }

}
