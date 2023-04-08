using MediatR;

namespace BarberScheduler.Application.Commands;

public record struct CreateUserCommand(
    string userName,
    string name,
    string firstName,
    string lastName,
    bool owne) : IRequest
{ }

