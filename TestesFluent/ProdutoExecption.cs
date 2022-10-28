public class ProdutoExecption : Exception
{
    public ProdutoExecption(string? message):base(message){}
    public ProdutoExecption(string? message, Exception? innerException):base(message,innerException){}
}