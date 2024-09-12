

using System;
using System.Collections.Generic;

namespace Pastelaria.Web.Application.Tarefa
{
  public  class TarefaModel
    {

        public int IdTarefa { get; set; }
        public IEnumerable<UsuarioModel> Usuario { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAtribuicao { get; set; } = DateTime.Now;
        public DateTime? DataConclusao { get; set; }
        public int IdCriadorTarefa{ get; set; }
        public bool Ind_Ativo { get; set; }
    }
}
