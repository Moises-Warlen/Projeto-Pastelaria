using Pastelaria.Web.Application.Endereco;
using Pastelaria.Web.Application.Tarefa;
using Pastelaria.Web.Application.Telefone;
using System;
using System.Collections.Generic;

public class UsuarioModel
{
    public int IdUsuario { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public DateTime DataNascimento { get; set; }
    public string TelefoneFixo { get; set; }
    public string Celular { get; set; }
    public string Endereco { get; set; }
    public PerfilModel Perfil { get; set; }
    public IEnumerable<TelefoneModel> Telefones { get; set; }
    public IEnumerable<EnderecoModel> Enderecos { get; set; }
    public List<TarefaModel> Tarefas { get; set; }
    public bool Ind_Ativo { get; set; }

}
