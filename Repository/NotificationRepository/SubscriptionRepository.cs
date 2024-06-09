using Data.NotificationData;
using Data.NotificationData;
using Data.UserData;
using DTO.NotificationDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Repository.NotificationRepository;

public class SubscriptionRepository(UserManager<User> userManager, ApplicationContext context) : ISubscriptionRepository
{
    private ApplicationContext _context = context;
    private DbSet<Subscription> _subscriptions = context.Set<Subscription>();
    private DbSet<Notification_type> _notificationTypes = context.Set<Notification_type>();

    public async Task<SubscriptionDTO> Get(long id)
    {
        var subscription = _subscriptions
            .Include(e=>e.User)
            .Include(e=>e.Notification_type)
            .SingleOrDefault(e => e.Id == id);
        if (subscription == null) return await Task.FromResult<SubscriptionDTO>(null);

        return await Task.FromResult(new SubscriptionDTO
        {
            Id = subscription.Id,
            TypeName = subscription.Notification_type.Name,
            UserName = subscription.User.UserName,
            Status = subscription.Status
        });
    }

    public async Task<List<SubscriptionDTO>> GetAll()
    {
        var subscriptions = _subscriptions
            .Include(e => e.User)
            .Include(e => e.Notification_type)
            .ToList();
        return await Task.FromResult(subscriptions.Select(subscription => new SubscriptionDTO()
        {
            Id = subscription.Id,
            UserName = subscription.User.UserName,
            TypeName = subscription.Notification_type.Name,
            Status = subscription.Status
        }).ToList());
    }

    public async Task<IActionResult> Insert(CreateSubscriptionDTO dto)
    {
        var user = await userManager.FindByNameAsync(dto.UserName);
        var notificationType = _notificationTypes.SingleOrDefault(e => e.Name == dto.TypeName);
        if (user == null) return new BadRequestObjectResult("Пользователь не найден");
        if (notificationType == null) return new BadRequestObjectResult("Метод получения не найден");
        var subscription = new Subscription
        {
            Status = dto.Status,
            TypeId = notificationType.Id,
            UserId = user.Id
        };
        _subscriptions.Add(subscription);
        await _context.SaveChangesAsync();
        return new OkResult();
    }

    public async Task<IActionResult> Update(UpdateSubscriptionDTO dto)
    {
        var user = await userManager.FindByNameAsync(dto.UserName);
        var notificationType = _notificationTypes.SingleOrDefault(e => e.Name == dto.TypeName);
        var subscription = _subscriptions.SingleOrDefault(e => e.Id == dto.Id);
        if (user == null) return new BadRequestObjectResult("Пользователь не найден");
        if (notificationType == null) return new BadRequestObjectResult("Метод получения не найден");
        if (subscription == null) return new BadRequestObjectResult("Подписка не найдена");
        subscription.UserId = user.Id;
        subscription.TypeId = notificationType.Id;
        subscription.Status = dto.Status;
        _subscriptions.Update(subscription);
        await _context.SaveChangesAsync();
        return new OkResult();
    }

    public void Delete(long id)
    {
        var subscription = _subscriptions.SingleOrDefault(e => e.Id == id);
        if (subscription == null) return;
        _subscriptions.Remove(subscription);
        _context.SaveChanges();
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}