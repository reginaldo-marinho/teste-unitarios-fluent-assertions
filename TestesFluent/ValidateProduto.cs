public class ValidateProduto
{
    public static void Validar(bool condicao, string mensagem){
        if (condicao)
            throw new ProdutoExecption(mensagem);
    }
}