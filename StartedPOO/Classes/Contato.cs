using System.Diagnostics;

namespace StartedPOO.Classes
{
  class Contato
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
      return "\nConato: " + this.DadosContato + "\nTipo do contato: " + this.Tipo;
    }
  }
}
