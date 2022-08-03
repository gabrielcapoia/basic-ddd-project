using Capoia.Core.Messages;
using System.Threading.Tasks;

namespace Capoia.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}
