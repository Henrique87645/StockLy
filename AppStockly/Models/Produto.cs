using System;
using System.Collections.Generic;
using System.Text;

namespace AppStockly.Models
{
    public class CadProduto
    {
        public string Produto { get; set; }
        public string Codigo { get; set; }
        public string Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }
        public int EstoqueMinimo { get; set; }
    }
}
