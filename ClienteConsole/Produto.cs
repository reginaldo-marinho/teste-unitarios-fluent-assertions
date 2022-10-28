public class Produto
{
    private decimal _Preco {get;set;}
    private string? _Nome {get;set;}
    public decimal Preco 
    { 
        get => this._Preco; 
        set 
        {
            ValidateProduto.Validar(value <= 0, "Preço do produto é obrigatório");
            ValidateProduto.Validar(value <= 1500, "Produto não  deve custar menos de 1500 reais");
            this._Preco = value;
        } 
    }
    public string Nome 
    { 
        get => this._Nome; 
        set 
        {
            ValidateProduto.Validar(string.IsNullOrEmpty(value),"Produto deve ter um nome");
            ValidateProduto.Validar(value.Length > 12 , "Produto deve ter no máximo 12 caracteres");
            this._Nome = value;
        } 
    }


}