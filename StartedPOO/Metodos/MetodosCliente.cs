using System;

namespace StartedPOO.Classes
{
  public partial class Cliente
  {
    public void Gravar()
    {
      Console.WriteLine("Gravando");
    }

    public void Apagar()
    {
      Console.WriteLine("Apagando");
    }

    public void ListContatos()
    {
      foreach (Contato c in this.Contatos) {
        Console.WriteLine(c);
      }
    }

    public void AddNewContato(Contato contanto)
    {
      this.Contatos.Add(contanto);
    }

    public override string ToString()
    {
      return "Cliente: " + this.Nome;
    }
  }
}
