namespace DTO.NotificationDTO;

public class Notification_DataDTO
{
    public long Id { get; set; }
    public string? UserName { get; set; }
    public DateTime DispatchDateTime { get; set; }
    public string NotificationTypeName { get; set; }
    public string PatternName { get; set; }
    public string PatternDefaultText { get; set; }
    public string AdditionalText { get; set; }
}