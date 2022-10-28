namespace FluentTest;
using FluentAssertions;

[TestClass]
public class ProdutoTest1
{
    [TestMethod]
    public void ProdutoNomeObrigatorio()
    {
        string username = "dennis";
        username.Should().Be("jonas");

    }
}