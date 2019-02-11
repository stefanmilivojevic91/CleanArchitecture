using Microsoft.Extensions.DependencyInjection;
using LoginRequest = Domain.UseCases.Login.Request;
using LoginResponse = Domain.UseCases.Login.Response;
using LoginUseCase = Domain.UseCases.Login.UseCase;
using Domain.Commons;
using Domain.PortsAndAdapters.Repositories;
using Infrastructure.Repositories;

namespace Infrastructure.DependencyInjection
{
    public class ServiceRegister
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUseCase<LoginRequest, Either<LoginResponse, NullUseCaseResponse>>, LoginUseCase>();
            services.AddScoped<IUsersRepository, UsersRepository>();
        }
    }
}
