using StartedPOO.Classes;
using System;

namespace StartedPOO
{
  class Program
  {
    static void Main(string[] args)
    {
      var cliente = new Cliente(0, "JOSE MURILLO", new DateTime(2019, 12, 12));

      Console.WriteLine(cliente);
    }
  }
}
