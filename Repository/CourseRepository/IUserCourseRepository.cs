using DTO.CourseDTO;

namespace Repository.CourseRepository;

public interface IUserCourseRepository
{
    UserCourseDTO Get(long Id);

    List<UserCourseDTO> GetAll();
}