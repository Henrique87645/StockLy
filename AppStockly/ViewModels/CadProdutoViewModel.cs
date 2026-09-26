using AppStockly.Models;

namespace AppStockly.ViewModels
{
    public class CadProdutoViewModel : BaseNotifyViewModel
    {

        //Nome do Produto
        private string _produto; //BACKEND
        public string Produto  //FRONTEND
        {
            get { return _produto; }
            set
            {
                _produto = value;
                OnPropertyChanged();  //LEITURA do Front -> Produto e vou jogar para o meu backend -> _produto
            }
        }

        private string _mensagemValidacaoNomeProduto;
        public string MensagemValidacaoNomeProduto
        {
            get { return _mensagemValidacaoNomeProduto; }
            set
            {
                _mensagemValidacaoNomeProduto = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirValidacaoNomeProduto;
        public bool ExibirValidacaoNomeProduto
        {
            get { return _exibirValidacaoNomeProduto; }
            set
            {
                _exibirValidacaoNomeProduto = value;
                OnPropertyChanged();
            }
        }

        //Nome do Produto
        private string _modelo; //BACKEND
        public string Modelo  //FRONTEND
        {
            get { return _modelo; }
            set
            {
                _modelo = value;
                OnPropertyChanged();  //LEITURA do Front -> Produto e vou jogar para o meu backend -> _produto
            }
        }

        private string _mensagemValidacaoModelo;
        public string MensagemValidacaoModelo
        {
            get { return _mensagemValidacaoModelo; }
            set
            {
                _mensagemValidacaoModelo = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoModelo;
        public bool ExibirMensagemValidacaoModelo
        {
            get { return _exibirMensagemValidacaoModelo; }
            set
            {
                _exibirMensagemValidacaoModelo = value;
                OnPropertyChanged();
            }
        }


        //Codigo do produto
        private string _Codigo;
        public string Codigo
        {
            get { return _Codigo; }
            set
            {
                _Codigo = value;
                OnPropertyChanged(nameof(Codigo));
            }
        }

        private string _mensagemValidacaoCodigo;
        public string MensagemValidacaoCodigo
        {
            get { return _mensagemValidacaoCodigo; }
            set
            {
                _mensagemValidacaoCodigo = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoCodigo;
        public bool ExibirMensagemValidacaoCodigo
        {
            get { return _exibirMensagemValidacaoCodigo; }
            set
            {
                _exibirMensagemValidacaoCodigo = value;
                OnPropertyChanged();
            }
        }


        //Fornecedores
        private string _Fornecedor;
        public string Fornecedor
        {
            get { return _Fornecedor; }
            set
            {
                _Fornecedor = value;
                OnPropertyChanged(nameof(Fornecedor));
            }
        }

        private string _mensagemValidacaoFornecedor;
        public string MensagemValidacaoFornecedor
        {
            get { return _mensagemValidacaoFornecedor; }
            set
            {
                _mensagemValidacaoFornecedor = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoFornecedor;
        public bool ExibirMensagemValidacaoFornecedor
        {
            get { return _exibirMensagemValidacaoFornecedor; }
            set
            {
                _exibirMensagemValidacaoFornecedor = value;
                OnPropertyChanged();
            }
        }


        //Quantidades
        private string _Quantidade;
        public string Quantidade
        {
            get { return _Quantidade; }
            set
            {
                _Quantidade = value;
                OnPropertyChanged(nameof(Quantidade));
            }
        }

        private string _mensagemValidacaoQuantidade;
        public string MensagemValidacaoQuantidade
        {
            get { return _mensagemValidacaoQuantidade; }
            set
            {
                _mensagemValidacaoQuantidade = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoQuantidade;
        public bool ExibirMensagemValidacaoQuantidade
        {
            get { return _exibirMensagemValidacaoQuantidade; }
            set
            {
                _exibirMensagemValidacaoQuantidade = value;
                OnPropertyChanged();
            }
        }


        //Preço de Compra
        private string _PrecoCompra;
        public string PrecoCompra
        {
            get { return _PrecoCompra; }
            set
            {
                _PrecoCompra = value;
                OnPropertyChanged(nameof(PrecoCompra));
            }
        }

        private string _mensagemValidacaoPrecoCompra;
        public string MensagemValidacaoPrecoCompra
        {
            get { return _mensagemValidacaoPrecoCompra; }
            set
            {
                _mensagemValidacaoPrecoCompra = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoPrecoCompra;
        public bool ExibirMensagemValidacaoPrecoCompra
        {
            get { return _exibirMensagemValidacaoPrecoCompra; }
            set
            {
                _exibirMensagemValidacaoPrecoCompra = value;
                OnPropertyChanged();
            }
        }


        //Preço de vendas
        private string _PrecoVenda;
        public string PrecoVenda
        {
            get { return _PrecoVenda; }
            set
            {
                _PrecoVenda = value;
                OnPropertyChanged(nameof(PrecoVenda));
            }
        }

        private string _mensagemValidacaoPrecoVenda;
        public string MensagemValidacaoPrecoVenda
        {
            get { return _mensagemValidacaoPrecoVenda; }
            set
            {
                _mensagemValidacaoPrecoVenda = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoPrecoVenda;
        public bool ExibirMensagemValidacaoPrecoVenda
        {
            get { return _exibirMensagemValidacaoPrecoVenda; }
            set
            {
                _exibirMensagemValidacaoPrecoVenda = value;
                OnPropertyChanged();
            }
        }


        //Estoque Minimo
        private string _estoqueMinimo;
        public string EstoqueMinimo
        {
            get { return _estoqueMinimo; }
            set
            {
                _estoqueMinimo = value;
                OnPropertyChanged(nameof(EstoqueMinimo));
            }
        }

        private string _mensagemValidacaoEstoqueMinimo;
        public string MensagemValidacaoEstoqueMinimo
        {
            get { return _mensagemValidacaoEstoqueMinimo; }
            set
            {
                _mensagemValidacaoEstoqueMinimo = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemValidacaoEstoqueMinimo;
        public bool ExibirMensagemValidacaoEstoqueMinimo
        {
            get { return _exibirMensagemValidacaoEstoqueMinimo; }
            set
            {
                _exibirMensagemValidacaoEstoqueMinimo = value;
                OnPropertyChanged();
            }
        }


        //------------------------------------------------------------------
                                    //Commands
        //------------------------------------------------------------------


        public Command SalvarCommand
        {
            get
            {
                return new Command(() =>
                {
                    Produto novoProduto = new Produto
                    {
                        NomeProduto = Produto,
                        Modelo = Modelo,
                        Codigo = Codigo,
                        Fornecedor = Fornecedor,
                        Quantidade = int.Parse(Quantidade),
                        PrecoCompra = decimal.Parse(PrecoCompra),
                        PrecoVenda = decimal.Parse(PrecoVenda),
                        EstoqueMinimo = int.Parse(EstoqueMinimo)
                    };

                    ProdutoSingleton.Instancia.Produtos.Add(novoProduto);
                });
            }
        }


        public Command VoltarCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new pgPrincipal());
                });
            }
        }

        //------------------------------------------------------------------
                                    //Validações
        //------------------------------------------------------------------

        private void Validacoes()
        {
            ValidarProduto();
            ValidarModelo();
            ValidarCodigo();
            ValidarFornecedor();
            ValidarQuantidade();
            ValidarPrecoCompra();
            ValidarPrecoVenda();
            ValidarEstoqueMinimo();
        }
        private void ValidarProduto()
        {
            if (string.IsNullOrWhiteSpace(Produto))
            {
                MensagemValidacaoNomeProduto = "O nome do produto é obrigatório.";
                ExibirValidacaoNomeProduto = true;
            }

            else if (!Produto.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                MensagemValidacaoNomeProduto = "O nome possui caracteres inválidos.";
                ExibirValidacaoNomeProduto = true;
            }
        }

        private void ValidarModelo()
        {
            if (string.IsNullOrWhiteSpace(Modelo))
            {
                MensagemValidacaoNomeProduto = "O nome do modelo é obrigatório.";
                ExibirValidacaoNomeProduto = true;
            }
            else if (Modelo.Length < 3)
            {
                MensagemValidacaoCodigo = "O modelo do produto deve ter pelo menos 3 caracteres.";
                ExibirMensagemValidacaoCodigo = true;
            }
        }

        private void ValidarCodigo()
        {
            if (string.IsNullOrWhiteSpace(Codigo))
            {
                MensagemValidacaoCodigo = "O código do produto é obrigatório.";
                ExibirMensagemValidacaoCodigo = true;
            }
            else if (Codigo.Length < 3)
            {
                MensagemValidacaoCodigo = "O código do produto deve ter pelo menos 3 caracteres.";
                ExibirMensagemValidacaoCodigo = true;
            }
        }

        private void ValidarFornecedor()
        {
            if (string.IsNullOrWhiteSpace(Fornecedor))
            {
                MensagemValidacaoFornecedor = "O fornecedor é obrigatório.";
                ExibirMensagemValidacaoFornecedor = true;
            }
            else if (Fornecedor.Length < 3)
            {
                MensagemValidacaoFornecedor = "O fornecedor deve ter pelo menos 3 caracteres.";
                ExibirMensagemValidacaoFornecedor = true;
            }
        }

        private void ValidarQuantidade()
        {
            if (string.IsNullOrWhiteSpace(Quantidade))
            {
                MensagemValidacaoQuantidade = "A quantidade é obrigatória.";
                ExibirMensagemValidacaoQuantidade = true;
            }
            else if (!int.TryParse(Quantidade, out int quantidade))
            {
                MensagemValidacaoQuantidade = "Informe uma quantidade válida.";
                ExibirMensagemValidacaoQuantidade = true;
            }
            else if (quantidade < 0)
            {
                MensagemValidacaoQuantidade = "A quantidade não pode ser negativa.";
                ExibirMensagemValidacaoQuantidade = true;
            }
        }

        private void ValidarPrecoCompra()
        {
            if (string.IsNullOrWhiteSpace(PrecoCompra))
            {
                MensagemValidacaoPrecoCompra = "O preço de compra é obrigatório.";
                ExibirMensagemValidacaoPrecoCompra = true;
            }
            else if (!decimal.TryParse(PrecoCompra, out decimal preco))
            {
                MensagemValidacaoPrecoCompra = "Informe um preço válido.";
                ExibirMensagemValidacaoPrecoCompra = true;
            }
            else if (preco <= 0)
            {
                MensagemValidacaoPrecoCompra = "O preço de compra deve ser maior que zero.";
                ExibirMensagemValidacaoPrecoCompra = true;
            }
        }

        private void ValidarPrecoVenda()
        {
            if (string.IsNullOrWhiteSpace(PrecoVenda))
            {
                MensagemValidacaoPrecoVenda = "O preço de venda é obrigatório.";
                ExibirMensagemValidacaoPrecoVenda = true;
            }
            else if (!decimal.TryParse(PrecoVenda, out decimal preco))
            {
                MensagemValidacaoPrecoVenda = "Informe um preço válido.";
                ExibirMensagemValidacaoPrecoVenda = true;
            }
            else if (preco <= 0)
            {
                MensagemValidacaoPrecoVenda = "O preço de venda deve ser maior que zero.";
                ExibirMensagemValidacaoPrecoVenda = true;
            }
        }

        private void ValidarEstoqueMinimo()
        {
            if (string.IsNullOrWhiteSpace(EstoqueMinimo))
            {
                MensagemValidacaoEstoqueMinimo = "O estoque mínimo é obrigatório.";
                ExibirMensagemValidacaoEstoqueMinimo = true;
            }
            else if (!int.TryParse(EstoqueMinimo, out int estoque))
            {
                MensagemValidacaoEstoqueMinimo = "Informe uma quantidade válida.";
                ExibirMensagemValidacaoEstoqueMinimo = true;
            }
            else if (estoque < 0)
            {
                MensagemValidacaoEstoqueMinimo = "O estoque mínimo não pode ser negativo.";
                ExibirMensagemValidacaoEstoqueMinimo = true;
            }
        }
    }
}
