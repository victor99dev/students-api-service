using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using studentsAPI.Models.Dtos.StudentDtos;
using studentsAPI.Models.Entities;
using studentsAPI.Repository.Interfaces;

namespace studentsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _repository;
        private readonly IMapper _mapper;

        public StudentController(IStudentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost("post")]
        public async Task<IActionResult> Post(StudentCreateDto student)
        {
            var createStudent = _mapper.Map<Student>(student);

            _repository.Add(createStudent);

            return await _repository.SaveChangesAsync()
                ? Ok("The student is registered")
                : BadRequest("Error registering student");
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> Get()
        {
            var getStudent = await _repository.GetAll();

            return getStudent.Any()
                ? Ok(getStudent)
                : NotFound("Student's is not found");
        }

        [HttpGet("get-by/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var getStudent = await _repository.GetById(id);

            var studentReturn = _mapper.Map<StudentDetailDto>(getStudent);

            return studentReturn != null
                    ? Ok(studentReturn)
                    : BadRequest("Student is not found");
        }
        
        [HttpPut("update/{id}")]
        public async Task<IActionResult> Put(Guid id, StudentUpdateDto student)
        {
            var getStudent = await _repository.GetById(id);

            if (getStudent == null) 
                return NotFound("Theacher is not found");

            var studentUpdate = _mapper.Map(student, getStudent);

            _repository.Update(studentUpdate);

            return await _repository.SaveChangesAsync()
                ? Ok("Student updated successfully")
                : BadRequest("Error updating Student");
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var getStudent = await _repository.GetById(id);

            if (getStudent == null)
                return NotFound("Student is not found");

            _repository.Delete(getStudent);

            return await _repository.SaveChangesAsync()
                ? Ok("Student deleted successfully")
                : BadRequest("Erro deleting student");
        }
    }
}