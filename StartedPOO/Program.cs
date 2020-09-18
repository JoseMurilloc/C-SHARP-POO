using StartedPOO.Classes;
using System;
using System.Linq;

namespace StartedPOO
{
  class Program
  {
    static void Main(string[] args)
    {
      var cliente = new Cliente(0, "JOSE MURILLO", new DateTime(2019, 12, 12), new Contato(0, "65656-45454", "Telefone"));

      cliente.AddNewContato(new Contato(1, "464645-415", "Telefone"));

      cliente.ListContatos();

      cliente.Gravar();
      cliente.Apagar();


      //foreach (var cont in cliente.Contatos) {
      //  if (cont.Tipo == "Telefone") {
      //    Console.WriteLine(cont);
      //  }
      //}

      // Resumindo em uma linha o codígo comentado acima
      cliente.Contatos.ForEach(cont => {
        if (cont.Tipo == "Telefone") {
          Console.WriteLine(cont);
        }
      });
      Console.WriteLine("-- Contatos --");

      var contatosTelefone = cliente.Contatos.FindAll(cont => cont.Tipo == "Telefone");
      contatosTelefone.ForEach(cont => Console.WriteLine(cont));
      // Exemplo usando expressões lambdas
      var contato = cliente.Contatos.FirstOrDefault(c => c.Tipo == "Telefone");

      Console.WriteLine("-- Contatos --");

      Console.WriteLine("Somente o primeiro telefone");
      Console.WriteLine(contato);

      Console.ReadLine();
    }
  }
}
