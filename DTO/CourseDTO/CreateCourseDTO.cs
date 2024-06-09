using System.ComponentModel.DataAnnotations;

namespace DTO.CourseDTO;

public class CreateCourseDTO
{
    [Required(ErrorMessage = $"Поле 'Курс' обязательно для заполнения")]
    public string CourseName { get; set; }
    
    [Required(ErrorMessage = $"Поле 'Цена' обязательна для заполнения")]
    public int Price { get; set; }
    
    [Required(ErrorMessage = $"Поле 'Автор' обязательна для заполнения")]
    public string Author { get; set; }
}