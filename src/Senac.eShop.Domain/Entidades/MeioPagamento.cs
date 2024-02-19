using Senac.eShop.Core.ObejetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.eShop.Domain.Entidades
{
    public class MeioPagamento : Entidade
    {
        protected MeioPagamento() { }
        public MeioPagamento(string alias, string cartaoId, string ultimos4, Cliente cliente)
        {
            Alias = alias;
            CartaoId = cartaoId;
            Ultimos4 = ultimos4;
            ClienteId = cliente.Id;
            Cliente = cliente;
        }

        public string Alias { get; private set; }
        public string CartaoId { get; private set; }
        public string Ultimos4 { get; private set; }
        public Guid ClienteId { get; private set; }
        public Cliente Cliente { get; private set; }

        public void SetAlias(string alias)
        {
            Alias = alias;
        }
        public void SetCartaoId(string cartaoId)
        {
            CartaoId = cartaoId;
        }
        public void SetUltimos4(string ultimos4)
        {
            Ultimos4 = ultimos4;
        }
    }
}
