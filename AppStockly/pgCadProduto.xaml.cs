namespace AppStockly;

public partial class pgCadProduto : ContentPage
{
    public pgCadProduto()
    {
        InitializeComponent();
    }

    private async void btnSalvar_Clicked(object sender, EventArgs e)
    {

        ValidationComponent nome =
            new ValidationComponent(txtNome, lblValidationNome);

        ValidationComponent codigo =
            new ValidationComponent(txtCodigo, lblValidationCodigo);

        ValidationComponent fornecedor =
            new ValidationComponent(txtFornecedor, lblValidationFornecedor);

        ValidationComponent quantidade =
            new ValidationComponent(txtQuantidade, lblValidationQuantidade);

        ValidationComponent precoCompra =
            new ValidationComponent(txtPrecoCompra, lblValidationPrecoCompra);

        ValidationComponent precoVenda =
            new ValidationComponent(txtPrecoVenda, lblValidationPrecoVenda);

        ValidationComponent estoqueMinimo =
            new ValidationComponent(txtEstoqueMinimo, lblValidationEstoqueMinimo);


        bool bNome = ValidarNome(nome);

        bool bCodigo = ValidarCodigo(codigo);

        bool bFornecedor = ValidarFornecedor(fornecedor);

        bool bQuantidade = ValidarQuantidade(quantidade);

        bool bPrecoCompra = ValidarPrecoCompra(precoCompra);

        bool bPrecoVenda = ValidarPrecoVenda(
            precoVenda,
            precoCompra);

        bool bEstoqueMinimo = ValidarEstoqueMinimo(
            estoqueMinimo,
            quantidade);


        if (!bNome ||
            !bCodigo ||
            !bFornecedor ||
            !bQuantidade ||
            !bPrecoCompra ||
            !bPrecoVenda ||
            !bEstoqueMinimo)
        {
            return;
        }



        await DisplayAlert(
            "Sucesso",
            "Produto cadastrado com sucesso!",
            "OK");


        await Navigation.PopAsync();
    }

    // VALIDAÇÃO DO NOME

    private bool ValidarNome(ValidationComponent campo)
    {
        if (campo.IsEmpty())
        {
            campo.SetValidation(
                "* Informe o nome do produto.");

            return false;
        }

        if (!campo.GetText().All(
                c => char.IsLetterOrDigit(c) ||
                     char.IsWhiteSpace(c)))
        {
            campo.SetValidation(
                "* O nome possui caracteres inválidos.");

            return false;
        }

        campo.HideValidation();

        return true;
    }

    // VALIDAÇÃO DO CÓDIGO

    private bool ValidarCodigo(ValidationComponent campo)
    {
        if (campo.IsEmpty())
        {
            campo.SetValidation(
                "* Informe o código do produto.");

            return false;
        }

        if (campo.GetText().Length < 3)
        {
            campo.SetValidation(
                "* O código deve possuir no mínimo 3 caracteres.");

            return false;
        }

        if (!campo.GetText().All(
                c => char.IsLetterOrDigit(c) || c == '-'))
        {
            campo.SetValidation(
                "* Use apenas letras, números e hífen.");

            return false;
        }

        campo.HideValidation();

        return true;
    }

    // VALIDAÇÃO DO FORNECEDOR

    private bool ValidarFornecedor(ValidationComponent campo)
    {
        if (campo.IsEmpty())
        {
            campo.SetValidation(
                "* Informe o fornecedor.");

            return false;
        }

        if (campo.GetText().Length < 8)
        {
            campo.SetValidation(
                "* O fornecedor deve possuir no mínimo 8 caracteres.");

            return false;
        }

        if (!campo.GetText().All(
                c => char.IsLetter(c) ||
                     char.IsWhiteSpace(c)))
        {
            campo.SetValidation(
                "* O fornecedor possui caracteres inválidos.");

            return false;
        }

        campo.HideValidation();

        return true;
    }

    // VALIDAÇÃO DA QUANTIDADE

    private bool ValidarQuantidade(ValidationComponent campo)
    {
        if (campo.IsEmpty())
        {
            campo.SetValidation(
                "* Informe a quantidade.");

            return false;
        }

        if (!int.TryParse(campo.GetText(), out int valor))
        {
            campo.SetValidation(
                "* Informe uma quantidade válida usando apenas números.");

            return false;
        }

        if (valor < 0)
        {
            campo.SetValidation(
                "* A quantidade não pode ser negativa.");

            return false;
        }

        campo.HideValidation();

        return true;
    }

    // VALIDAÇÃO DO PREÇO DE COMPRA

    private bool ValidarPrecoCompra(ValidationComponent campo)
    {
        if (campo.IsEmpty())
        {
            campo.SetValidation(
                "* Informe o preço de compra.");

            return false;
        }

        if (!decimal.TryParse(
                campo.GetText().Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal valor))
        {
            campo.SetValidation(
                "* Informe um preço válido.");

            return false;
        }

        if (valor <= 0)
        {
            campo.SetValidation(
                "* O preço deve ser maior que zero.");

            return false;
        }

        campo.HideValidation();

        return true;
    }

    // VALIDAÇÃO DO PREÇO DE VENDA

    private bool ValidarPrecoVenda(
        ValidationComponent campo,
        ValidationComponent campoCompra)
    {
        if (campo.IsEmpty())
        {
            campo.SetValidation(
                "* Informe o preço de venda.");

            return false;
        }

        if (!decimal.TryParse(
                campo.GetText().Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal venda))
        {
            campo.SetValidation(
                "* Informe um preço válido.");

            return false;
        }

        if (venda <= 0)
        {
            campo.SetValidation(
                "* O preço deve ser maior que zero.");

            return false;
        }

        // VALIDAÇÃO EXTRA PERSONALIZADA

        decimal.TryParse(
            campoCompra.GetText().Replace(",", "."),
            System.Globalization.NumberStyles.Any,
            System.Globalization.CultureInfo.InvariantCulture,
            out decimal compra);

        if (venda < compra)
        {
            campo.SetValidation(
                "* O preço de venda não pode ser menor que o preço de compra.");

            return false;
        }

        campo.HideValidation();

        return true;
    }

    // VALIDAÇÃO DO ESTOQUE MÍNIMO

    private bool ValidarEstoqueMinimo(
        ValidationComponent campo,
        ValidationComponent campoQuantidade)
    {
        if (campo.IsEmpty())
        {
            campo.SetValidation(
                "* Informe o estoque mínimo.");

            return false;
        }

        if (!int.TryParse(campo.GetText(), out int minimo))
        {
            campo.SetValidation(
                "* Informe um número inteiro válido.");

            return false;
        }

        if (minimo < 0)
        {
            campo.SetValidation(
                "* O estoque mínimo não pode ser negativo.");

            return false;
        }


        int.TryParse(
            campoQuantidade.GetText(),
            out int quantidade);


        if (minimo > quantidade)
        {
            campo.SetValidation(
                "* O estoque mínimo não pode ser maior que o estoque atual.");

            return false;
        }

        campo.HideValidation();

        return true;
    }


    // VOLTAR

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}

