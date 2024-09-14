using System;
using System.Collections.Generic;
using Pastelaria.Domain.Usuario;
using Pastelaria.Domain.Usuario.Dto;
using Pastelaria.Repository.Infra;
using Pastelaria.Repository.Infra.Extensions;
using Pastelaria.Domain.Perfil.Dto;
using Pastelaria.Domain.Telefone.Dto;
using Pastelaria.Domain.Endereco.Dto;
using Pastelaria.Domain.Tarefa.Dto;

namespace Pastelaria.Repository
{
    // Classe de repositório para gerenciar dados de usuários
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        // Construtor que injeta a conexão com o banco de dados
        public UsuarioRepository(IDatabaseConnection connection) : base(connection)
        {
        }

        // Enumeração que define os nomes dos procedimentos armazenados
        private enum Procedures
        {
            BuscarUsuariosAtivos,     // Listar usuários ativos
        }
        public IEnumerable<UsuarioDto> Get()
        {
            ExecuteProcedure(Procedures.BuscarUsuariosAtivos);  // Executa a procedure para buscar usuários ativos

            var usuarios = new List<UsuarioDto>();  // Inicializa a lista de usuários que será preenchida

            using (var r = ExecuteReader())  // Executa o leitor para ler os resultados
            {
                while (r.Read())  // Percorre cada linha do resultado
                {
                    // Mapeia os dados do banco de dados para a classe UsuarioDto
                    var usuario = new UsuarioDto
                    {
                        IdUsuario = r.ReadAttr<int>("IdUsuario"),
                        Nome = r.ReadAttr<string>("Nome"),
                        Email = r.ReadAttr<string>("Email"),
                        Senha = r.ReadAttr<string>("Senha"),
                        DataNascimento = r.ReadAttr<DateTime>("DataNascimento"),
                        IdPerfil = r.ReadAttr<int>("IdPerfil"),
                        // Inicializa as listas de Telefones, Enderecos e Tarefas (pode ser preenchido separadamente depois)
                        Telefones = new List<TelefoneDto>(),
                        Enderecos = new List<EnderecoDto>(),
                        Tarefas = new List<TarefaDto>()
                    };

                    usuarios.Add(usuario);  // Adiciona o usuário mapeado à lista
                }
            }

            return usuarios;  // Retorna a lista de usuários
        }




        public UsuarioDto Get(int? id = default(int?), string nome = null)
        {
            throw new NotImplementedException();
        }

        public int Post(UsuarioDto usuario)
        {
            throw new NotImplementedException();
        }

        public UsuarioDto PostLogin(UsuarioDto usuario)
        {
            throw new NotImplementedException();
        }

        public void Put(UsuarioDto usuario)
        {
            throw new NotImplementedException();
        }

        public UsuarioDto PutDesativaUsuario(int IdUsuario)
        {
            throw new NotImplementedException();
        }

      
    }
}
