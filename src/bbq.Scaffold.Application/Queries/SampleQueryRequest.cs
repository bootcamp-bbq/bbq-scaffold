using bbq.Scaffold.Application.Response;
using MediatR;

namespace bbq.Scaffold.Application.Queries
{
    public class SampleQueryRequest : IRequest<SampleQueryResponse>
    {
        public string QueryInputParam { get; set; }
    }
}
