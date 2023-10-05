using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation_Example.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IValidator<User> _validator;

    public UserController(IValidator<User> validator)
    {
        _validator = validator;
    }

    [HttpPost]
    public async Task<IActionResult> Post(User user)
    {
        var validationResult = await  _validator.ValidateAsync(user);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }

        return Ok();
    }
}