using Senac.eShop.Core.Enums;
using Senac.eShop.Core.ObejetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.eShop.Domain.Entidades
{
    public class Venda : Entidade
    {
        const int TAMANHO_CODIGO = 5;
        
        protected Venda() { }
        public Venda(Cliente cliente, decimal valorTotal, CupomDesconto cupomDesconto, Endereco endereco, Carinho carinho,MeioPagamento meioPagamento, decimal valorDesconto = 0)
        {
            ClienteId = cliente.Id;
            Cliente = cliente;
            ValorTotal = valorTotal;
            CupomDesconto = cupomDesconto;
            CupomDescontoId = cupomDesconto.Id;
            Endereco = endereco;
            EnderecoId = endereco.Id;
            ValorDesconto = valorDesconto;
            Carinho = carinho;
            CarrinhoId = carinho.Id;
            MeioPagamento = meioPagamento;
            MeioPagamentoId = meioPagamento.Id;
            Status = VendaStatus.Criada;
            CodigoCompra = SetCodigoAleatorio(TAMANHO_CODIGO);
        }

        public Guid ClienteId { get; private set; }
        public Cliente Cliente { get; private set; }
        public decimal ValorTotal { get; private set; }
        public decimal ValorDesconto { get; private set; }
        public Guid CupomDescontoId { get; private set; }
        public CupomDesconto CupomDesconto { get; private set; }
        public Guid EnderecoId { get; private set; }
        public Endereco Endereco { get; private set; }
        public decimal ValorFinal { get; private set; }
        public Guid CarrinhoId { get; private set; }
        public Carinho Carinho { get; private set; }
        public Guid MeioPagamentoId { get; private set; }
        public MeioPagamento MeioPagamento { get; private set; }
        public VendaStatus Status { get; private set; }
        public string CodigoCompra { get; private set; }    

                      
        private readonly List<VendaItem> _VendaItens;

        public IReadOnlyCollection<VendaItem> VendaItens => _VendaItens;



        public void AplicaCupom(CupomDesconto cupom)
        {

            CupomDescontoId = cupom.Id;
            CupomDesconto = cupom;

            CalcularValorTotalDesconto();


        }
        public void SetEndereco(Endereco endereco)
        {
            EnderecoId = endereco.Id;
            Endereco = endereco;
        }
        public void CalcularValorVenda()
        {
            if(VendaItens == null)
            {
                ValorTotal = 0;
            }
            else
            {
                ValorTotal = VendaItens.Sum(vi => vi.ValorItem);
            }
        }

        public void CalcularValorTotalDesconto()
        {
            decimal desconto = 0;
            decimal Valor = ValorTotal;

            if(CupomDesconto.TipoDescontoCupom == TipoDesconto.Percentual)
            {
                desconto = (Valor * CupomDesconto.Valor) / 100;
               
            }
            else
            {
                desconto = CupomDesconto.Valor;
            }
            Valor -= desconto;
            if(Valor <0)
            {
                ValorTotal = 0;
            }
            else
            {
                ValorTotal = Valor;
            }

        }
        public void SetMeioPagamento (MeioPagamento meioPagamento)
        {
            MeioPagamento = meioPagamento;
            MeioPagamentoId = meioPagamento.Id;

        }
        private string SetCodigoAleatorio (int tamanho)
        {
            var LetrasNumeros = "ABCDEFGHIJKLMNOPQRSTUVWXYZ012345666789";
            var aleatorio = new Random();
            var resultado = new string (Enumerable.Repeat(LetrasNumeros,tamanho).Select(s => s[aleatorio.Next(s.Length)]).ToArray());
            return resultado;
        }
        public void Setcodigo()
        {
            CodigoCompra = SetCodigoAleatorio(5);
        }


        public void AutorizeVendaStatus() =>
            Status = VendaStatus.Autorizada;

        public void CancelaVendaStatus() =>
            Status = VendaStatus.Cancelada;
        public void EntregaVendaStatus() =>
            Status = VendaStatus.Entreque;
        public void PagueVendaStatus() =>
            Status = VendaStatus.Paga;














    }
   
}

