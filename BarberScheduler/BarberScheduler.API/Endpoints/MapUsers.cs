using BarberScheduler.API.Models;
using BarberScheduler.Application.Commands;
using BarberScheduler.Reads.Queries;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BarberScheduler.API.Endpoints;

public static class UsersMap
{
    public static IEndpointRouteBuilder MapUsers(this IEndpointRouteBuilder endpoints)
    {
        #region GET

        //endpoints.MapGet("users/{userId}", async ([FromServices] IQuerySession querySession, Guid userId) =>
        //  await querySession.Json.FindByIdAsync<UserViewModel>(userId))
        //  .WithName("GetUser")
        //  .WithOpenApi();

        endpoints.MapGet("users/{userId}", async (UsersQueries usersQueries, Guid userId) =>
          await usersQueries.GetUserByIdAsync(userId))
          .WithName("GetUser")
          .WithOpenApi();

        #endregion

        #region POST

        endpoints.MapPost("users/create", async (
            ISender sender,
            [FromBody] NewUserModel model) =>
        {
            var command = model.Adapt<CreateUserCommand>() with
            {
                userName = model.UserName,
                name = model.Name,
                firstName = model.FirstName,
                lastName = model.LastName
            };

            await sender.Send(command);
        })
            .WithName("CreateUser")
            .WithOpenApi();

        #endregion

        return endpoints;
    }
}
