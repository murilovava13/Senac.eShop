using Senac.eShop.Core.ObejetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.eShop.Domain.Entidades
{
    public class Cliente : Entidade
    {
        protected Cliente() { }
        
        public Cliente(string nome, string sobrenome, string email, string telefone, string documento, string sexo,Endereco enderecoCliente)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Telefone = telefone;
            Documento = documento;
            Sexo = sexo;
            EnderecoCliente = enderecoCliente;
            EnderecoId = enderecoCliente.Id;

        }

        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string Email { get; private set; }

        public string Telefone { get; private set; }

        public string Documento { get; private set; }

        public string Sexo { get; private set; }
        
        public Endereco EnderecoCliente { get; private set; }

        public Guid EnderecoId { get; private set; }

        private List<MeioPagamento> _MeioPagamento = new List<MeioPagamento>();

        public IEnumerable<MeioPagamento> _MeiosPagamento => _MeioPagamento.AsReadOnly();

        public void SetEndeco (Endereco endereco)
        {
            EnderecoCliente = endereco;
            EnderecoId = endereco.Id;
        }

        public void SetNome (string nome,string sobrenome) 
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public void SetEmail (string email) 
        { 
            Email = email;
       
        }
        public void SetTelefone (string telefone)
        {
            Telefone = telefone;
        }
        public void SetDocumento (string documento)
        {
            Documento = documento;
        }
        public void SetSexo (string sexo)
        {
            Sexo = sexo;
        }




    }
}
