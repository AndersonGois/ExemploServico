
using WcfService.DataContract.DataContract;
using WcfService.DataContract.MessageDataContract;
using WcfService.DataContract.ServiceDataContract;

namespace WcfService
{
    public class ServiceUsuario : IServiceUsuario
    {
        public UsuarioResponse GetUsuario(UsuarioRequest usuarioRequest)
        {
            var usuarioResponse = new UsuarioResponse
                {
                    UsuarioDataContract =
                        new UsuarioDataContract
                            {
                                Codigo = usuarioRequest.UsuarioDataContract.Codigo,
                                Nome = string.Concat(usuarioRequest.UsuarioDataContract.Nome, " Servico")
                            }
                };
            return usuarioResponse;
        }
    }
}
