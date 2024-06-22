using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface ICommand : ICommand<MediatR.Unit>
    {
    }
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}