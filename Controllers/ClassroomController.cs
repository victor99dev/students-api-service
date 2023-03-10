using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using studentsAPI.Models.Dtos.ClassroomDtos;
using studentsAPI.Models.Entities;
using studentsAPI.Repository.Interfaces;

namespace studentsAPI.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class ClassroomController : ControllerBase
    {
        private readonly IClassroomRepository _repository;
        private readonly IMapper _mapper;

        public ClassroomController( IClassroomRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost("post")]
        public async Task<IActionResult> Post(ClassroomCreateDto classroom)
        {
            var createClassroom = _mapper.Map<Classroom>(classroom);

            _repository.Add(createClassroom);

            return await _repository.SaveChangesAsync()
                ? Ok("The classroom is registered")
                : BadRequest("Error registering classroom");
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> Get()
        {

            var getClassroom = await _repository.GetAll();

            return getClassroom.Any()
                ? Ok(getClassroom)
                : NotFound("Classroom is not found");
        }

        [HttpGet("get-by/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var getClassroom = await _repository.GetById(id);

            var classroomReturn = _mapper.Map<ClassroomDetailDto>(getClassroom);

            return classroomReturn != null
                ? Ok(classroomReturn)
                : BadRequest("Classroom is not found");
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Put(Guid id, ClassroomUpdateDto classroom)
        {
            var getClassroom = await _repository.GetById(id);

            if (getClassroom == null) 
                return NotFound("Classroom is not found");

            var classroomUpdate = _mapper.Map(classroom, getClassroom);

            _repository.Update(classroomUpdate);

            return await _repository.SaveChangesAsync()
                ? Ok("Classroom updated successfully")
                : BadRequest("Error updating Classroom");
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var getClassroom = await _repository.GetById(id);

            if (getClassroom == null)
                return NotFound("Classroom is not found");

            _repository.Delete(getClassroom);

            return await _repository.SaveChangesAsync()
                ? Ok("Classroom deleted successfully")
                : BadRequest("Erro deleting classroom");
        }
    }
}