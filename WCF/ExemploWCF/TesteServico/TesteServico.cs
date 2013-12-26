using NUnit.Framework;

using TesteServico.ServiceReference55;

namespace TesteServico
{
    [TestFixture]
    public class TesteServicos
    {
        [Test]
        public void GetUsuario()
        {
            using (var usuarioClient = new ServiceUsuarioClient())
            {
                var usuarioData = new UsuarioData() { Codigo = 1, Nome = "Anderson" };
                usuarioClient.GetUsuario(ref usuarioData);
                Assert.AreEqual(usuarioData.Nome,"Anderson Servico");
            }
        }
    }
}
