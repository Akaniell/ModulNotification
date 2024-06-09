namespace DTO.NotificationDTO;

public class CreateNotification_DataDTO
{
    public string? UserName { get; set; }
    public string NotificationTypeName { get; set; }
    public string PatternName { get; set; }
    public string AdditionalText { get; set; }
}