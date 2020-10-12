using System.Threading.Tasks;
using MediatR;

namespace MediatorUsage
{
    public class System
    {
        private readonly IMediator _mediator;

        public System(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task MultipleMediatorUsages()
        {
            await _mediator.Send(new SomeQuery1());
            await _mediator.Send(new SomeQuery2());
        }

        public async Task SingleMediatorUsage()
        {
            await _mediator.Send(new SomeQuery1());
        }
    }
}