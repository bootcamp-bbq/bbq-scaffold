using System;
using System.Threading;
using System.Threading.Tasks;
using bbq.Scaffold.Application.Commands;
using bbq.Scaffold.Application.Response;
using bbq.Scaffold.Domain;
using MediatR;

namespace bbq.Scaffold.Application.RequestHandler
{
    public class SampleCommandRequestHandler : IRequestHandler<SampleCommandRequest, SampleCommandResponse>
    {
        private SampleCommandDomain _domain;

        public SampleCommandRequestHandler(SampleCommandDomain domain)
        {
            _domain = domain ?? throw new ArgumentNullException(nameof(_domain));
        }

        public async Task<SampleCommandResponse> Handle(SampleCommandRequest request, CancellationToken cancellationToken)
        {
            return new SampleCommandResponse {
                CommandOutput = _domain.DoAction(request.CommandInputParam)
            };
        }
    }
}
