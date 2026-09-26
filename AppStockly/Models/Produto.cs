using System;
using System.Collections.Generic;
using System.Text;

namespace AppStockly.Models
{
    public class Produto
    {
        //Atributos do cadastro
        public string NomeProduto { get; set; } //esse
        public string Modelo { get; set; } //esse
        public string Codigo { get; set; }
        public string ImagemProduto { get; set; }
        public string Fornecedor { get; set; }
        public int Quantidade { get; set; } //esse
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; } //esse
        public int EstoqueMinimo { get; set; }
    }
}
