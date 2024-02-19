using Senac.eShop.Core.Enums;
using Senac.eShop.Core.ObejetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.eShop.Domain.Entidades
{
    public class CupomDesconto : Entidade
    {
        protected CupomDesconto() { }

        public CupomDesconto(string codigo, decimal valor, int quantidade, DateTime expiraEm, bool ativo, TipoDesconto tipoDescontoCupom)
        {
            Codigo = codigo;
            Valor = valor;
            Quantidade = quantidade;
            ExpiraEm = expiraEm;
            Ativo = ativo;
            TipoDescontoCupom = tipoDescontoCupom;
        }

        public string Codigo { get; private set; }
        public decimal Valor { get; private set; }
        public int Quantidade { get; private set; }
        public DateTime ExpiraEm { get; private set; }
        public bool Ativo { get; private set; }
        public TipoDesconto TipoDescontoCupom { get; private set; }

        public void SetCodigo(String codigo)
        {
            Codigo = codigo;
        }

        public void SetValor(decimal valor)
        {
            Valor = valor;
        }
        public void SetQuantidade (int quantidade)
        {
            Quantidade = quantidade;
        }
        public void SetExpiraEm ( DateTime expiraEm)
        {
            ExpiraEm = expiraEm;
        }
        public void SetAtivo (bool ativo)
        {
            Ativo = ativo;
        }
        public void SetTipoDesconto (TipoDesconto tipoDescontoCupom)
        {
            TipoDescontoCupom = tipoDescontoCupom;  
        }



    }
}
