using DTO.NotificationDTO;
using Microsoft.AspNetCore.Mvc;

namespace Repository.NotificationRepository;

public interface IMethodRepository
{
    Task<MethodDTO> Get(long id);
    Task<List<MethodDTO>> GetAll();
    Task<IActionResult> Insert(CreateMethodDTO dto);
    Task<IActionResult> Update(UpdateMethodDTO dto);
    void Delete(long id);
    void SaveChanges();
}