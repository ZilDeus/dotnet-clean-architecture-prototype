namespace GymManagement.Dtos.Subscriptions;

public record CreateSubscriptionRequest(
    SubscriptionType SubscriptionType,
    Guid AdminId);
