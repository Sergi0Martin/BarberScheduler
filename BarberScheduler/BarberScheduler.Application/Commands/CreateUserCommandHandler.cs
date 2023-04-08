using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberScheduler.Application.Commands
{
    public sealed class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        public Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
