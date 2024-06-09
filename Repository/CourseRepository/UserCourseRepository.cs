using Data.CourseData;
using DTO.CourseDTO;
using Microsoft.EntityFrameworkCore;

namespace Repository.CourseRepository;

public class UserCourseRepository(ApplicationContext context) : IUserCourseRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<UserCourse> _userCourse = context.Set<UserCourse>();

    public UserCourseDTO Get(long Id)
    {
        var UserCourse = _userCourse.SingleOrDefault(e => e.Id ==Id);
        if (UserCourse == null) return null;

        var UserCourseDTO = new UserCourseDTO()
        {
            Id = UserCourse.Id,
            User_Id = UserCourse.User_id,
            Course_Id = UserCourse.Course_id
            
        };
        return UserCourseDTO;
    }

    public List<UserCourseDTO> GetAll()
    {
        var userCourses = _userCourse.ToList();
        return userCourses.Select(UserCourse => new UserCourseDTO
        {
            Id = UserCourse.Id,
            User_Id = UserCourse.User_id,
            Course_Id = UserCourse.Course_id
        }).ToList();
    }
}