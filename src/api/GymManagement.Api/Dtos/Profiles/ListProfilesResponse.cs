namespace GymManagement.Dtos.Profiles;

public record ListProfilesResponse(Guid? AdminId, Guid? ParticipantId, Guid? TrainerId);
