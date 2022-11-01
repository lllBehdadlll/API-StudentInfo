namespace StudentInfo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        

        public Student() { }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            
        }
    }
}
