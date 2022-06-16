using Line;
using System.Threading.Tasks;

namespace MyLineBot.EventHandlers
{
    public interface ILineEventHandler
    {
        LineEventType EventType { get; }

        Task Handle(ILineBot lineBot, ILineEvent evt);
    }
}