namespace LINQ
{
    public class Employee
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Position: {Position}, Salary: {Salary:C}";
        }
    }

}
