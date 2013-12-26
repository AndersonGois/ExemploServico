
using WcfService.DataContract.DataContract;
using System.ServiceModel;

namespace WcfService.DataContract.MessageDataContract
{
    [MessageContract]
    public class UsuarioRequest
    {
        [MessageBodyMember(Name = "UsuarioData")]
        public UsuarioDataContract UsuarioDataContract { get; set; }
    }
}
