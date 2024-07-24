namespace GymManagement.Dtos.Authentication;

public record LoginRequest(
    string Email,
    string Password);
