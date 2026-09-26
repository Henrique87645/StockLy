using System;
using System.Collections.Generic;
using System.Text;

namespace AppStockly.Models
{
    public sealed class CadProdutoSingleton
    {
        static CadProdutoSingleton _instancia;

        public static CadProdutoSingleton Instancia
        {
            get
            {
                return _instancia ??
                    (_instancia = new CadProdutoSingleton());
            }
        }

        public CadProdutoSingleton()
        {

        }

        //Cirar a lista de Produtos

        //Criar os metodos de adicionar

        //Criar os metodos de remover

        //Criar o metodo de Listar os Produtos
    }
}
