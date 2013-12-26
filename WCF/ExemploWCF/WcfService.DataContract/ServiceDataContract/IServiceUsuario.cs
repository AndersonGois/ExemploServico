
using WcfService.DataContract.MessageDataContract;
using System.ServiceModel;

namespace WcfService.DataContract.ServiceDataContract
{
    [ServiceContract(Name = "ServiceUsuario")]
    public interface IServiceUsuario
    {
        [OperationContract(Name = "GetUsuario")]
        UsuarioResponse GetUsuario(UsuarioRequest usuarioRequest);
    }
}
