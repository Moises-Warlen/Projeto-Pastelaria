
using Pastelaria.Domain.Perfil.Dto;
using System.Collections.Generic;

namespace Pastelaria.Domain.Perfil
{
   public interface IPerfilRepository
    {
        // Declara um método para obter uma coleção de objetos PerfilDto(obriga a criar esse metodo no repositorio de perfil)
        IEnumerable<PerfilDto> Get();
    }
}
