using Senac.eShop.Core.ObejetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.eShop.Domain.Entidades
{
    public class CarinhoItem : Entidade
    {
        protected CarinhoItem() { } 
        public CarinhoItem(Guid produtoId, Produto produto, Guid carinhoId, int quantidade)
        {
            ProdutoId = produtoId;
            Produto = produto;
            CarinhoId = carinhoId;
            Quantidade = quantidade;
        }

        public Guid ProdutoId { get; private set; }
        public Produto Produto { get; private set; }
        public Guid CarinhoId { get;  private set; }
        public int Quantidade { get; private set; }


        public void SetProduto(Produto produto)
        {
            ProdutoId = produto.Id;
            Produto = produto;

        }
        public void SetQuantidade(int quantidade)
        {
            Quantidade = quantidade;
        }
        public void SetAicionarRemoverQuantidade (int quantidade)
        {
            Quantidade= quantidade;
        }
    }
}
