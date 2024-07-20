using Microsoft.AspNetCore.Mvc;
using GymManagement.Application.Subscriptions;
using MediatR;
namespace GymManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionsController : ControllerBase
{
  private readonly IMediator _mediator;

  public SubscriptionsController(IMediator mediator){
    _mediator = mediator;
  }

  [HttpPost]
  public async Task<IActionResult> CreateSubscription(CreateSubscriptionCommand request){

    var response = await _mediator.Send(request);
    return response.MatchFirst(
        data => Ok(data),
        _ => Problem()
        );
  }
}
