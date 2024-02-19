using Senac.eShop.Core.ObejetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.eShop.Domain.Entidades
{
    public class Carinho : Entidade
    {
        protected Carinho() { }

        public Carinho(Cliente cliente)
        {
            Cliente = cliente;
            ClienteId = cliente.Id;
            //inicializando a minha lista
            Itens = new List<CarinhoItem>();
        }

        public Guid ClienteId { get;  private set; }

        public Cliente Cliente { get; private set;}
        public List<CarinhoItem> Itens { get; private set; } 
        
        public void AddItem (CarinhoItem item)
        {
            Itens.Add (item);
        }
        public void RemoveItem (CarinhoItem item)
        {
            Itens.Remove (item);
        }

        public void LimpaCarimnho (CarinhoItem item)
        {
            Itens = new List<CarinhoItem> ();
        }
        public void AlteraQuantidadeItem  (CarinhoItem item, int novaQuantidade)
        {
            CarinhoItem itemEncontrado = Itens.Where(i => i.Id == item.Id).First();
            itemEncontrado.SetQuantidade (novaQuantidade);
        }

    }
}
