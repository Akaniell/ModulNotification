using DTO.NotificationDTO;
using Microsoft.AspNetCore.Mvc;

namespace Repository.NotificationRepository;

public interface ISubscriptionRepository
{
    Task<SubscriptionDTO> Get(long id);
    Task<List<SubscriptionDTO>> GetAll();
    Task<IActionResult> Insert(CreateSubscriptionDTO dto);
    Task<IActionResult> Update(UpdateSubscriptionDTO dto);
    void Delete(long id);
    void SaveChanges();
}