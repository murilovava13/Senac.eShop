using Senac.eShop.Core.ObejetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.eShop.Domain.Entidades
{
    public class Produto : Entidade
    {
        protected Produto() { }
        public Produto(string nome, string descricao, bool ativo, decimal perco, string imagem, int quantidadeEstoque)
        {
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Preco = perco;
            Imagem = imagem;
            QuantidadeEstoque = quantidadeEstoque;
        }

        
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public Decimal Preco{ get; private set; }
        public string Imagem { get; private set; }
        public int QuantidadeEstoque { get; private set; }


        public void SetNome (string nome)
        {
            Nome=nome;
        }
        public void SetDescricao (string descricao)
        {
            Descricao=descricao;
        }
        public void SetAtivo (bool ativo)
        {
            Ativo= ativo;
        }
        public void SetPreco (decimal preco)
        {
            Preco =preco;
        }
        public void SetImagem (string imagem)
        {
            Imagem = imagem;
        }
        public void SetQuantidadeEstoque(int quantidadeEstoque)
        {
            QuantidadeEstoque= quantidadeEstoque;
        }


        public void SetAddEstoque (int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }

        public void SetAlteraEstoque (int quantidade)
        {
            if (quantidade <= QuantidadeEstoque)
            {
                QuantidadeEstoque = QuantidadeEstoque - quantidade;
            }
            else
            {
                throw new Exception("Quantidade maior que o disponível no estoque,.");
            }



        }














    }
}
