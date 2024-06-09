using DTO.UserDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.UserService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("users")]
public class UserController (IUserService userService) : Controller
{
    [Route("{id}")] 
    [HttpGet] 
    public async Task<JsonResult> GetUser(Guid id) 
    {
        var user = await userService.GetUser(id.ToString());
        return Json(user);
    }
    
    [HttpGet] 
    public async Task<JsonResult> GetUsers() 
    {
        var users = await userService.GetUsers(); 
        return Json(users);
    }

    [Route("create")] 
    [HttpPost]
    public async Task<JsonResult> CreateUser(CreateUserDTO dto) 
    {
        var result = await userService.InsertUser(dto);
        return Json(result);
    }
    
    [Authorize]
    [Route("update")] 
    [HttpPatch] 
    public async Task<JsonResult> UpdateUser(UpdateUserDTO dto) 
    {
        await userService.UpdateUser(dto);
        return Json("updated"); 
    }
    
    [Authorize]
    [Route("delete/{id}")]
    [HttpDelete]
    public JsonResult DeleteUser(string id) 
    {
        userService.DeleteUser(id); 
        return Json("deleted"); 
    }
}