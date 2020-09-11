using System;

namespace StartedPOO.Classes
{
  public class Cliente
  {
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public DateTime DataCadastro { get; set; }
    private Contato Contato { get; set; }


    public Cliente(int Codigo, string Nome, DateTime DataCadastro)
    {
      this.Codigo = Codigo;
      this.Nome = Nome;
      this.DataCadastro = DataCadastro;

      this.Contato = new Contato(0, "66-666", "Tefefone");
    }

    public override string ToString()
    {
      return "Cliente: " + this.Nome + " Seu contato: " + this.Contato;
    }
  }
}
