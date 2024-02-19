using Senac.eShop.Core.Enums;
using Senac.eShop.Core.ObejetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.eShop.Domain.Entidades
{
    public class Endereco : Entidade
    {
        protected Endereco() { }

        public Endereco(string logradouro, string complemento, string bairro, string cidade, string estado, string cep, TipoEndereco tipo)
        {
            Logradouro = logradouro;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            Tipo = tipo;
        }

        

        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Cep { get; private set; }

        public TipoEndereco Tipo { get; private set; }

        public void SetLogradouro(string logradouro)
        {
            Logradouro = logradouro;
        }
        public void SetComplemento(string complemento)
        {
            Complemento = complemento;
        }
        public void SetBairro (string bairro)
        {
            Bairro = bairro;
        }
        public void SetCidade (string cidade)
        {
            Cidade = cidade;

        }
        public void SetEstado (string estado)
        { 
            Estado = estado;
        }
        public void SetCep (string cep)
        {
            Cep = cep;
        }
        public void SetTipo (TipoEndereco tipoEndereco)
        {
            Tipo = tipoEndereco;
        }


    }
}
