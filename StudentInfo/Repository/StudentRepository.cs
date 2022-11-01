using Microsoft.EntityFrameworkCore;
using StudentInfo.Models;

namespace StudentInfo.Repository
{
    public class StudentRepository
    {
        private readonly StudentContext _context;

        public StudentRepository(StudentContext context)
        {
            _context = context;
        }

        public int Create(Student entity)
        {
            var entityTracker = _context.Students.Add(entity);
            _context.SaveChanges();
            return entityTracker.Entity.Id;
        }
        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }
        public Student GetById(int id)
        {
            return _context.Students.Find(id);
        }
    }
}
