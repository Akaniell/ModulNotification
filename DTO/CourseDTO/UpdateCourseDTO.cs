namespace DTO.CourseDTO;

public class UpdateCourseDTO
{
    public long Id { get; set; }
    
    public string CourseName { get; set; }
    
    public int Price { get; set; }
    
    public string Author { get; set; }
}