using DTO.AuthDTO;
using Microsoft.AspNetCore.Mvc;
using Services.JwtService;

namespace OnlineTrainigAPI.Controllers;

[ApiController]
[Route("auth")]
public class AuthController(IJwtService jwtService):Controller
{
    [Route("signin")]
    public async Task<ActionResult> SignIn(AuthSignInDTO dto)
    {
        var authData = await jwtService.CreateToken(dto);
        if (authData == null) return Json("Пользователь не найден или введен неправильный пароль");
        return Json(authData);
    }
}