using Atividade.Enumeracoes.Entities.Enums;
using System;


namespace Atividade.Enumeracoes.Entities
{
    class Pedido
    {
        public string Nome { get; set; }

        public DateTime Momento { get; set; }

        public StatusPedido Status { get; set; }

        public override string ToString()
        {
            return Nome + ", " + Momento + ", " + Status;
        }
    }
}
