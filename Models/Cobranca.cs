namespace GerenciadorCobrancas.Models;

public class Cobranca
{
    public int Id { get; set; }
    public string Cliente { get; set; }
    public string Documento { get; set; }
    public decimal Valor { get; set; }
    public DateTime Vencimento { get; set; }
    public string Situacao { get; set; }
}
