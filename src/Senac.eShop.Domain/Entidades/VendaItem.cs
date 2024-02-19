using Senac.eShop.Core.ObejetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.eShop.Domain.Entidades
{
    public class VendaItem : Entidade
    {
        protected VendaItem() { }
        public VendaItem(Venda venda, Produto produto, int quantidade, decimal valorUnitario)
        {
            VendaId = venda.Id;
            Venda = venda;
            ProdutoId = produto.Id;
            Produto = produto;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public Guid VendaId { get; private set; }
        public Venda Venda { get; private set; }
        public Guid ProdutoId { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorUnitario { get; private set; }

        public void SetVenda(Venda venda)
        {
            VendaId = venda.Id;
            Venda = venda;

        }
        public void SetProduto(Produto produto)
        {
            ProdutoId = produto.Id;
            Produto = produto;
        }
        public void SetVAlorUnitario(decimal valorUnitario)
        {
            ValorUnitario = valorUnitario;
        }
        public void SetQuantidade(int quantidade)
        {
            Quantidade = quantidade;
        }


        public decimal ValorItem
        {
            get { return ValorUnitario * Quantidade; }

        }

    }


}
