namespace DTO.NotificationDTO;

public class UpdateNotification_DataDTO
{
    public long Id { get; set; }
    public string? UserName { get; set; }
    public string NotificationTypeName { get; set; }
    public string PatternName { get; set; }
    public string AdditionalText { get; set; }
}