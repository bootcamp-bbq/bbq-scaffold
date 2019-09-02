using bbq.Scaffold.Application.Response;
using MediatR;

namespace bbq.Scaffold.Application.Commands
{
    public class SampleCommandRequest : IRequest<SampleCommandResponse>
    {
        public string CommandInputParam { get; set; }
    }
}
