using Data.CourseData;
using DTO.CourseDTO;

namespace Service.CourseService;

public interface IUserCourseService
{
    UserCourseDTO GetUserCourse(long Id);

    List<UserCourseDTO> GetUserCourses();
}