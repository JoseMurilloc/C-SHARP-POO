using System.Diagnostics;

namespace StartedPOO.Classes
{
  public class Contato
  {
    public int Codigo { get; set; }
    public string DadosContato { get; set; }
    public string Tipo { get; set; }

    public Contato(int Codigo, string DadosContato, string Tipo)
    {
      this.Codigo = Codigo;
      this.DadosContato = DadosContato;
      this.Tipo = Tipo;
    }

    public override string ToString()
    {
      return "Codigo: " + this.Codigo + " | DadosContato: " + this.DadosContato +
        " | Tipo: " + this.Tipo;
    }
  }
}
