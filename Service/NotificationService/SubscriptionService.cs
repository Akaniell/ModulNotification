using DTO.NotificationDTO;
using Microsoft.AspNetCore.Mvc;
using Repository.NotificationRepository;

namespace Service.NotificationService;

public class SubscriptionService(ISubscriptionRepository subscriptionRepository) : ISubscriptionService
{
    private ISubscriptionRepository _subscriptionRepository = subscriptionRepository;
    
    public async Task<SubscriptionDTO> GetSubscription(long id) 
    {
        return await _subscriptionRepository.Get(id);
    }

    public async Task<List<SubscriptionDTO>> GetSubscriptions() 
    {
        return await _subscriptionRepository.GetAll(); 
    }
    
    public async Task<IActionResult> InsertSubscription(CreateSubscriptionDTO dto)
    {
        return await _subscriptionRepository.Insert(dto);
    }

    public async Task<IActionResult> UpdateSubscription(UpdateSubscriptionDTO dto)
    {
        return await _subscriptionRepository.Update(dto);
    }

    public void DeleteSubscription(long id)
    {
        _subscriptionRepository.Delete(id);
    }
}