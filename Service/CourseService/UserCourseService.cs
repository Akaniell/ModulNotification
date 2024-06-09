using Data.CourseData;
using DTO.CourseDTO;
using Repository.CourseRepository;

namespace Service.CourseService;

public class UserCourseService(IUserCourseRepository userCourseRepository) : IUserCourseService
{
    private IUserCourseRepository _userCourseRepository = userCourseRepository;

    public UserCourseDTO GetUserCourse(long Id)
    {
        return _userCourseRepository.Get(Id);
    }

    public List<UserCourseDTO> GetUserCourses()
    {
        return _userCourseRepository.GetAll();
    }
}