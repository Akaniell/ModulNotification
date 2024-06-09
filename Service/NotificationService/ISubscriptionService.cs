using DTO.NotificationDTO;
using Microsoft.AspNetCore.Mvc;

namespace Service.NotificationService;

public interface ISubscriptionService
{
    Task<SubscriptionDTO> GetSubscription(long id);
    Task<List<SubscriptionDTO>> GetSubscriptions();
    Task<IActionResult> InsertSubscription(CreateSubscriptionDTO dto);
    Task<IActionResult> UpdateSubscription(UpdateSubscriptionDTO dto);
    void DeleteSubscription(long id);
}