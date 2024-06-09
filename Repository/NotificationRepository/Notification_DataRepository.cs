using Data.NotificationData;
using Data.UserData;
using DTO.NotificationDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Repository.NotificationRepository;

public class Notification_DataRepository(UserManager<User> userManager, ApplicationContext context) : INotification_DataRepository
{
    private ApplicationContext _context = context;
    private DbSet<Notification_Data> _notification_Datas = context.Set<Notification_Data>();
    private DbSet<Pattern> _patterns = context.Set<Pattern>();
    private DbSet<Notification_type> _notification_Types = context.Set<Notification_type>();
    private DbSet<NotificationContent> _notificationContents = context.Set<NotificationContent>();

    public async Task<Notification_DataDTO> Get(long id)
    {
        var notification_data = _notification_Datas
            .Include(e => e.User)
            .Include(e => e.NotificationContent)
            .Include(e=>e.NotificationContent.Pattern)
            .Include(e=>e.NotificationContent.Notification_type)
            .SingleOrDefault(e => e.Id == id);
        
        return await Task.FromResult(new Notification_DataDTO
        {
            Id = notification_data.Id,
            UserName = notification_data.User.UserName,
            DispatchDateTime = notification_data.DispatchDateTime,
            NotificationTypeName = notification_data.NotificationContent.Notification_type.Name,
            PatternName = notification_data.NotificationContent.Pattern.Name,
            PatternDefaultText = notification_data.NotificationContent.Pattern.Default_text,
            AdditionalText = notification_data.AdditionalText
        });
    }

    public async Task<List<Notification_DataDTO>> GetAll()
    {
        var notification_datas = _notification_Datas
            .Include(e => e.User)
            .Include(e => e.NotificationContent)
            .Include(e=>e.NotificationContent.Pattern)
            .Include(e=>e.NotificationContent.Notification_type)
            .ToList();

        return await Task.FromResult(notification_datas.Select(notification_data => new Notification_DataDTO
            {
                Id = notification_data.Id,
                UserName = notification_data.User.UserName,
                DispatchDateTime = notification_data.DispatchDateTime,
                NotificationTypeName = notification_data.NotificationContent.Notification_type.Name,
                PatternName = notification_data.NotificationContent.Pattern.Name,
                PatternDefaultText = notification_data.NotificationContent.Pattern.Default_text,
                AdditionalText = notification_data.AdditionalText
            }).ToList());
    }

    public async Task<IActionResult> Insert(CreateNotification_DataDTO dto)
    {
        var user = await userManager.FindByNameAsync(dto.UserName);
        var notificationType = _notification_Types.SingleOrDefault(e => e.Name == dto.NotificationTypeName);
        var pattern = _patterns.SingleOrDefault(e => e.Name == dto.PatternName);
        var notificationContent = _notificationContents.SingleOrDefault(e => e.Notification_type.Name == dto.NotificationTypeName && e.Pattern.Name == dto.PatternName);
        if (user == null) return new BadRequestObjectResult("Пользователь не найден");
        if (notificationType == null) return new BadRequestObjectResult("Такого типа уведомлений не существует");
        if (pattern == null) return new BadRequestObjectResult("Такого шаблона не существует");
        if (notificationContent == null)
        {
            notificationContent = new NotificationContent
            {
                TypeId = notificationType.Id,
                PatternId = pattern.Id
            };
            _notificationContents.Add(notificationContent);
            await _context.SaveChangesAsync();
        }

        var notification_Data = new Notification_Data
        {
            UserId = user.Id,
            DispatchDateTime = DateTime.Now,
            NotificationContentId = notificationContent.Id,
            AdditionalText = dto.AdditionalText
        };
        _notification_Datas.Add(notification_Data);
        await _context.SaveChangesAsync();
        return new OkResult();
    }

    public async Task<IActionResult> Update(UpdateNotification_DataDTO dto)
    {
        var user = await userManager.FindByNameAsync(dto.UserName);
        var notificationType = _notification_Types.SingleOrDefault(e => e.Name == dto.NotificationTypeName);
        var pattern = _patterns.SingleOrDefault(e => e.Name == dto.PatternName);
        var notificationData = _notification_Datas.SingleOrDefault(e => e.Id == dto.Id);
        var notificationContent = _notificationContents.SingleOrDefault(e => e.Notification_type.Name == dto.NotificationTypeName && e.Pattern.Name == dto.PatternName);
        if (user == null) return new BadRequestObjectResult("Пользователь не найден");
        if (notificationType == null) return new BadRequestObjectResult("Такого типа уведомлений не существует");
        if (pattern == null) return new BadRequestObjectResult("Такого шаблона не существует");
        if (notificationData == null) return new BadRequestObjectResult("Такого уведомления не существует");
        notificationContent ??= new NotificationContent
        {
            TypeId = notificationType.Id,
            PatternId = pattern.Id
        };
        notificationData.UserId = user.Id;
        notificationData.DispatchDateTime = DateTime.Now;
        notificationData.NotificationContentId = notificationContent.Id;
        notificationData.AdditionalText = dto.AdditionalText;
        _notification_Datas.Update(notificationData);
        await _context.SaveChangesAsync();
        return new OkResult();
    }
    
    public void Delete(long id)
    {
        var notificationData = _notification_Datas.SingleOrDefault(e => e.Id == id);
        if (notificationData == null) return;
        _notification_Datas.Remove(notificationData);
        _context.SaveChanges();
    }
    
    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}