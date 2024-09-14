using Pastelaria.Domain.Endereco.Dto;
using Pastelaria.Domain.Perfil.Dto;
using Pastelaria.Domain.Tarefa.Dto;
using Pastelaria.Domain.Telefone.Dto;
using System;
using System.Collections.Generic;

namespace Pastelaria.Domain.Usuario.Dto
{
    public  class UsuarioDto
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public int IdPerfil { get; set; }
        public List<TelefoneDto> Telefones { get; set; }
        public List<EnderecoDto> Enderecos { get; set; }
        public List<TarefaDto> Tarefas { get; set; }
        public bool Ativo { get; set; }

    }
}
