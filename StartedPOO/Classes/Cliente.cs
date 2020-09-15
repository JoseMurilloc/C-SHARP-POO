using System;
using System.Collections.Generic;

namespace StartedPOO.Classes
{
  public partial class Cliente
  {
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public DateTime DataCadastro { get; set; }
    public List<Contato> Contatos { get; set; }


    public Cliente(int Codigo, string Nome, DateTime DataCadastro, Contato contato)
    {
      this.Codigo = Codigo;
      this.Nome = Nome;
      this.DataCadastro = DataCadastro;

      this.Contatos = new List<Contato>();

      this.Contatos.Add(new Contato(contato.Codigo, contato.DadosContato, contato.Tipo));
    }
  }
}
