using Atividade.Enumeracoes.Entities;
using Atividade.Enumeracoes.Entities.Enums;
using System;

namespace Atividade.Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido { Nome = "Kaue Malcon", Momento = DateTime.Now, Status = StatusPedido.Pagamento };
            Console.WriteLine(pedido);
        }
    }
}
