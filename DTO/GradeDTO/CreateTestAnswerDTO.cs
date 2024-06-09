using System.ComponentModel.DataAnnotations;

namespace DTO.GradeDTO;

public class CreateTestAnswerDTO
{
    [Required(ErrorMessage = "Поле 'ответ' обязательно для заполнения")]
    public string value { get; set; }
    [Required(ErrorMessage = "Поле 'номер варианта ответа' обязательно для заполнения")]
    public bool is_corect { get; set; }
    
}
