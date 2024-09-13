using Pastelaria.Domain.Perfil;
using Pastelaria.Domain.Perfil.Dto;
using Pastelaria.Repository.Infra;
using Pastelaria.Repository.Infra.Extensions;
using System.Collections.Generic;

namespace Pastelaria.Repository
{
   public class PerfilRepository : BaseRepository, IPerfilRepository
    {

        public PerfilRepository(IDatabaseConnection connection) : base(connection)
        {

        }
        // Enumeração que define os nomes dos procedimentos armazenados.
        // Usada para referenciar procedimentos armazenados no banco de dados.
        private enum Procedures
        {
            BuscarPerfilUsuario // Procedimento armazenado para listar todos os perfis.
        }

        public IEnumerable<PerfilDto> Get()
        {
            // Executa o procedimento armazenado para listar todos os perfis.
            ExecuteProcedure(Procedures.BuscarPerfilUsuario);
            // Usa um leitor de dados para ler o resultado do procedimento armazenado.
            // O resultado é convertido para uma coleção de objetos PerfilDto.
            using (var r = ExecuteReader())
                return r.CastEnumerable<PerfilDto>();
        }

    }
}
