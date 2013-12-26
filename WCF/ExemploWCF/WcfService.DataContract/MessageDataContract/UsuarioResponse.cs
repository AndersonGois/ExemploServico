
using System.ServiceModel;
using WcfService.DataContract.DataContract;

namespace WcfService.DataContract.MessageDataContract
{
    [MessageContract]
    public class UsuarioResponse
    {
        [MessageBodyMember(Name = "UsuarioData")]
        public UsuarioDataContract UsuarioDataContract { get; set; }
    }
}
