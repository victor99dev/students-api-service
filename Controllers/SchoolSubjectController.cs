using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using studentsAPI.Models.Dtos.SchoolSubjectDtos;
using studentsAPI.Models.Dtos.TeacherDtos;
using studentsAPI.Models.Entities;
using studentsAPI.Repository.Interfaces;

namespace studentsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class SchoolSubjectController : ControllerBase
    {
        private readonly ISchoolSubjectRepository _repository;
        private readonly IMapper _mapper;

        public SchoolSubjectController(
            ISchoolSubjectRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost("post")]
        public async Task<IActionResult> Post(SchoolSubjectCreateDto schoolSubject)
        {
            var createSchoolSubject = _mapper.Map<SchoolSubject>(schoolSubject);

            _repository.Add(createSchoolSubject);

            return await _repository.SaveChangesAsync()
                ? Ok("The school subject is registered")
                : BadRequest("Error registering school subject");
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> Get()
        {

            var getSchoolSubject = await _repository.GetAll();

            return getSchoolSubject.Any()
                ? Ok(getSchoolSubject)
                : NotFound("School subject's is not found");
        }

        [HttpGet("get-by/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var getSchoolSubject = await _repository.GetById(id);

            var schoolSubjectReturn = _mapper.Map<SchoolSubjectDetailDto>(getSchoolSubject);

            return schoolSubjectReturn != null
                ? Ok(schoolSubjectReturn)
                : BadRequest("School subject is not found");
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Put(Guid id, SchoolSubjectUpdateDto schoolSubject)
        {
            var getSchoolSubject = await _repository.GetById(id);

            if (getSchoolSubject == null) 
                return NotFound("School subject is not found");

            var schoolSubjectUpdate = _mapper.Map(schoolSubject, getSchoolSubject);

            _repository.Update(schoolSubjectUpdate);

            return await _repository.SaveChangesAsync()
                ? Ok("School subject updated successfully")
                : BadRequest("Error updating School subject");
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var getSchoolSubject = await _repository.GetById(id);

            if (getSchoolSubject == null)
                return NotFound("School subject is not found");

            _repository.Delete(getSchoolSubject);

            return await _repository.SaveChangesAsync()
                ? Ok("School subject deleted successfully")
                : BadRequest("Erro deleting School subject");
        }
    }
}