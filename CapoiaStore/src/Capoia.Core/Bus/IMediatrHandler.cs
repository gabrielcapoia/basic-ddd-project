using Capoia.Core.Messages;
using System.Threading.Tasks;

namespace Capoia.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<bool> EnviarComando<T>(T comando) where T : Command;
        //Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification;
    }
}
