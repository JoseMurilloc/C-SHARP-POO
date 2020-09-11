using StartedPOO.Classes;
using System;
using System.Linq;

namespace StartedPOO
{
  class Program
  {
    static void Main(string[] args)
    {
      var cliente = new Cliente(
        0, 
        "JOSE MURILLO", 
        new DateTime(2019, 12, 12),
        new Contato(0, "65656-45454", "Telefone")
      );

      cliente.AddNewContato(
       new Contato(1, "464645-415", "Telefone")
      );

      cliente.ListContatos();

      // Exemplo usando expressões lambdas
      var contato = cliente.Contatos.FirstOrDefault(c => c.Tipo == "Telefone");

      Console.WriteLine(contato);
    }
  }
}
