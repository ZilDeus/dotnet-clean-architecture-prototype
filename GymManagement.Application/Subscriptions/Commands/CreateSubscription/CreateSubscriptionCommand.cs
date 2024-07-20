using MediatR;
namespace GymManagement.Application.Subscriptions;

public class CreateSubscriptionCommand : IRequest<Guid>{
  public string SubscriptionType {get;set;} = null!;
  public Guid AdminId {get;set;}
}
