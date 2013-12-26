using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WcfService.DataContract.DataContract
{
    [DataContract(Name = "UsuarioData")]
    public class UsuarioDataContract
    {
        [DataMember(Name = "Codigo")]
        public int Codigo { get; set; }

        [DataMember(Name = "Nome")]
        public string Nome { get; set; }
    }
}
