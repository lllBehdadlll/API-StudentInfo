using Microsoft.AspNetCore.Mvc;
using StudentInfo.Models;
using StudentInfo.Repository;

namespace StudentInfo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArchiveController : ControllerBase
    {
        private readonly StudentRepository _studentRepository;
       

        public ArchiveController(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("[action]")]
        public IEnumerable<Student> StudentsInfo()
        {
            return _studentRepository.GetAll();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public Student StudentInfo(int id)
        {
            return _studentRepository.GetById(id);
        }

        [HttpPost]
        [Route("[action]")]
        public int AddStudents([FromBody] Student student)
        {
            var id = _studentRepository.Create(student);
            return id;
        }

    }
}