namespace BarberScheduler.Reads.ViewModels;

public record UserViewModel(
    Guid Id,
    string UserName,
    string FirstName,
    string LastName,
    bool Owner);
