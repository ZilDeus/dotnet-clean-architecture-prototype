using MediatR;
using ErrorOr;

namespace GymManagement.Application.Subscriptions;

public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, ErrorOr<Guid>>
{
  public async Task<ErrorOr<Guid>> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
  {
    return Guid.NewGuid();
  }
}
