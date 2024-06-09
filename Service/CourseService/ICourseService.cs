using DTO.CourseDTO;


namespace Service.CourseService;

public interface ICourseService
{
    CourseDTO GetCourse(long Id);
    List<CourseDTO> GetCourses();
    void InsertCourse(CreateCourseDTO dto);
    void UpdateCourse(UpdateCourseDTO dto);
    void DeleteCourse(long Id);
}