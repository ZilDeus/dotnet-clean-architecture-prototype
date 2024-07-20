using MediatR;
using ErrorOr;
namespace GymManagement.Application.Subscriptions;

public class CreateSubscriptionCommand : IRequest<ErrorOr<Guid>>{
  public string SubscriptionType {get;set;} = null!;
  public Guid AdminId {get;set;}
}
