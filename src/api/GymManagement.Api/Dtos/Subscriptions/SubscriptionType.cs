using System.Text.Json.Serialization;

namespace GymManagement.Dtos.Subscriptions;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SubscriptionType
{
    Free,
    Starter,
    Pro
}
