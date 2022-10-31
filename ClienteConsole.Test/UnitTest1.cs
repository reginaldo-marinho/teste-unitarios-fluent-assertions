namespace ClienteConsole.Test;
using ClienteConsole;
using FluentAssertions;

[TestClass]
public class UnitTest1
{
    Produto produto = new Produto ();
    [TestMethod]
    public void TestMethod1()
    {
        
        Action act = () => produto.Nome = "";

        act.Should().Throw<ProdutoExecption>().WithMessage("Produto deve ter um nome");
    }
}