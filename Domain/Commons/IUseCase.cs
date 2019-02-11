using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commons
{
    public interface IUseCase<TRequest, TResponse>
    {
        Task<TResponse> Execute(TRequest request);
    }
}
