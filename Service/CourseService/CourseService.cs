using DTO.CourseDTO;
using Repository.CourseRepository;

namespace Service.CourseService;

public class CourseService(ICourseRepository CourseRepository) : ICourseService
{
    private ICourseRepository _courseRepository = CourseRepository;

    public CourseDTO GetCourse(long id)
    {
        return _courseRepository.Get(id);
    }

    public List<CourseDTO> GetCourses()
    {
        return _courseRepository.GetAll();
    }

    public void InsertCourse(CreateCourseDTO dto)
    {
        _courseRepository.Insert(dto);
    }

    public void UpdateCourse(UpdateCourseDTO dto)
    {
        _courseRepository.Update(dto);
    }

    public void DeleteCourse(long id)
    {
        _courseRepository.Delete(id);
    }
}