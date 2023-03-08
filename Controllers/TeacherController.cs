using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using studentsAPI.Models.Dtos.TeacherDtos;
using studentsAPI.Models.Entities;
using studentsAPI.Repository.Interfaces;

namespace studentsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository _repository;
        private readonly IMapper _mapper;

        public TeacherController(ITeacherRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost("post")]
        public async Task<IActionResult> Post(TeacherCreateDto teacher)
        {
            var createTeacher = _mapper.Map<Teacher>(teacher);

            _repository.Add(createTeacher);

            return await _repository.SaveChangesAsync()
                ? Ok("The teacher is registered")
                : BadRequest("Error registering teacher");
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> Get()
        {
            var getTeacher = await _repository.GetAll();

            return getTeacher.Any()
                ? Ok(getTeacher)
                : NotFound("Theacher's is not found");
        }

        [HttpGet("get-by/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var getTeacher = await _repository.GetById(id);

            var teacherReturn = _mapper.Map<TeacherDto>(getTeacher);

            return teacherReturn != null
                    ? Ok(teacherReturn)
                    : BadRequest("Theacher is not found");
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Put(Guid id, TeacherUpdateDto teacher)
        {
            var getTeacher = await _repository.GetById(id);

            if (getTeacher == null) 
                return NotFound("Theacher is not found");

            var teacherUpdate = _mapper.Map(teacher, getTeacher);

            _repository.Update(teacherUpdate);

            return await _repository.SaveChangesAsync()
                ? Ok("Teacher updated successfully")
                : BadRequest("Error updating Teacher");
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var getTeacher = await _repository.GetById(id);

            if (getTeacher == null)
                return NotFound("Theacher is not found");

            _repository.Delete(getTeacher);

            return await _repository.SaveChangesAsync()
                ? Ok("Teacher deleted successfully")
                : BadRequest("Erro deleting teacher");
        }
    }
}