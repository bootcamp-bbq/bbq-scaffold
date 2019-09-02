using System;
using System.Threading;
using System.Threading.Tasks;
using bbq.Scaffold.Application.Queries;
using bbq.Scaffold.Application.Response;
using bbq.Scaffold.Domain;
using MediatR;

namespace bbq.Scaffold.Application.RequestHandler
{
    public class SampleQueryRequestHandler : IRequestHandler<SampleQueryRequest, SampleQueryResponse>
    {
        private SampleQueryDomain _domain;

        public SampleQueryRequestHandler(SampleQueryDomain domain)
        {
            _domain = domain ?? throw new ArgumentNullException(nameof(_domain));
        }

        public async Task<SampleQueryResponse> Handle(SampleQueryRequest request, CancellationToken cancellationToken)
        {
            return new SampleQueryResponse
            {
                QueryOutput = _domain.DoQuery(request.QueryInputParam)
            };
        }
    }
}
