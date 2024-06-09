using Data.CourseData;
using DTO.CourseDTO;
using Microsoft.EntityFrameworkCore;

namespace Repository.CourseRepository;

public class CourseRepository(ApplicationContext context) : ICourseRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<Course> _courses = context.Set<Course>();

    public CourseDTO Get(long id)
    {
        var course = _courses.SingleOrDefault(e => e.Id == id);
        if (course == null) return null;

        var courseDTO = new CourseDTO
        {
            Id = course.Id,
            CourseName = course.CourseName,
            Price = course.Price,
            Author = course.Author
        };

        return courseDTO;
    }

    public List<CourseDTO> GetAll()
    {
        var courses = _courses.ToList();

        return courses.Select(Course => new CourseDTO
        {
            Id = Course.Id,
            CourseName = Course.CourseName,
            Price = Course.Price,
            Author = Course.Author
        }).ToList();
    }
    
    public void Insert(CreateCourseDTO dto)
    {
        var course = new Course
        {
            CourseName = dto.CourseName,
            Price = dto.Price,
            Author = dto.Author
        };
        
        _courses.Add(course);
        context.SaveChanges();
    }

    public void Update(UpdateCourseDTO dto)
    {
        var course = _courses.SingleOrDefault(e => e.Id == dto.Id);
        if (course == null) return;

        course.CourseName = dto.CourseName;
        course.Price = dto.Price;
        course.Author = dto.Author;

        _courses.Update(course);
        context.SaveChanges();
    }
    
    public void Delete(long id)
    {
        var course = _courses.SingleOrDefault(e => e.Id == id);
        if (course == null) return;

        _courses.Remove(course);
        context.SaveChanges();
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }
}