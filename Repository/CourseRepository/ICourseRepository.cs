using DTO.CourseDTO;


namespace Repository.CourseRepository;

public interface ICourseRepository
{
    CourseDTO Get(long Id);
    List<CourseDTO> GetAll();
    void Insert(CreateCourseDTO dto);
    void Update(UpdateCourseDTO dto);
    void Delete(long Id);

}