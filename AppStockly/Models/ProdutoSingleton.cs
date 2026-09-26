using System;
using System.Collections.Generic;
using System.Text;

namespace AppStockly.Models
{
    public class ProdutoSingleton
    {
        private static ProdutoSingleton instancia;

        public List<Produto> Produtos { get; set; }

        private ProdutoSingleton()
        {
            Produtos = new List<Produto>();
        }

        public static ProdutoSingleton Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ProdutoSingleton();
                }

                return instancia;
            }
        }
        //ProdutoSingleton.Instancia
    }
}
