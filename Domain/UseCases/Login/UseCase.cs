using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Commons;
using Domain.PortsAndAdapters.Repositories;

namespace Domain.UseCases.Login
{
    public class UseCase : IUseCase<Request, Either<Response, NullUseCaseResponse>>
    {
        private readonly IUsersRepository _usersRepository;

        public UseCase(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<Either<Response, NullUseCaseResponse>> Execute(Request request)
        {
            var user = await _usersRepository.GetByUsername(request.Username);

            if (user == null)
            {
                return new Either<Response, NullUseCaseResponse>(NullUseCaseResponse.Null());
            }

            return new Either<Response, NullUseCaseResponse>(new Response
            {
                UserId = user.UserId
            });
        }
    }
}
