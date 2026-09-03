namespace AppStockly;

public partial class pgCadastro : ContentPage
{
    public pgCadastro()
    {
        InitializeComponent();
    }

    private void btnSalvar_Clicked(object sender, EventArgs e)
    {
        //Criar os componentes de validação
        ValidationComponent userName =
            new ValidationComponent(txtUserName, lblValidationUserName);

        ValidationComponent nome =
            new ValidationComponent(txtNome, lblValidationNome);

        ValidationComponent cpf =
            new ValidationComponent(txtCPF, lblValidationCPF);

        ValidationComponent email =
            new ValidationComponent(txtEmail, lblValidationEmail);

        ValidationComponent telefone =
            new ValidationComponent(txtTelefone, lblValidationTelefone);

        //ValidationComponent empresa =
        //    new ValidationComponent(txtTelefone, lblValidationEmpresa);

        ValidationComponent senha =
            new ValidationComponent(txtSenha, lblValidationSenha);

        ValidationComponent confirmarSenha =
            new ValidationComponent(txtConfirmarSenha, lblValidationConfirmarSenha);


        //Realizar as validações
        bool bUserName = ValidarUserName(userName);
        bool bNome = ValidarNome(nome);
        bool bCPF = ValidarCPF(cpf);
        bool bEmail = ValidarEmail(email);
        bool bTelefone = ValidarTelefone(telefone);
        bool bEmpresa = ValidarEmpresa();
        bool bSenha = ValidarSenha(senha);
        bool bConfirmarSenha = ValidarConfirmarSenha(confirmarSenha, senha);


        //Caso alguma validação tenha falhado
        if (!bUserName || !bNome || !bCPF || !bEmail ||
            !bTelefone || !bEmpresa || !bSenha || !bConfirmarSenha)
        {
            return;
        }


        //Caso todas as validações sejam aprovadas
        DisplayAlert("Cadastro", "Cadastro realizado com sucesso!", "OK");
    }


    private bool ValidarUserName(ValidationComponent UserName)
    {
        bool resultado = false;

        if (UserName.IsEmpty())
        {
            UserName.SetValidation("Campo obrigatório", true);
        }

        else if (UserName.GetText().Length < 5)
        {
            UserName.SetValidation(
                "Informe o User Name com no mínimo 5 caracteres.", true);
        }

        else
        {
            resultado = true;
            UserName.HideValidation();
        }

        return resultado;
    }


    private bool ValidarNome(ValidationComponent Nome)
    {
        bool resultado = false;

        if (Nome.IsEmpty())
        {
            Nome.SetValidation("Campo obrigatório", true);
        }

        else if (Nome.GetText().Length < 3)
        {
            Nome.SetValidation(
                "Informe o nome com no mínimo 3 caracteres.", true);
        }

        else if (Nome.GetText().Any(char.IsDigit))
        {
            Nome.SetValidation(
                "O nome não pode possuir números.", true);
        }

        else
        {
            resultado = true;
            Nome.HideValidation();
        }

        return resultado;
    }


    private bool ValidarCPF(ValidationComponent CPF)
    {
        bool resultado = false;

        if (CPF.IsEmpty())
        {
            CPF.SetValidation("Campo obrigatório", true);
        }

        else if (CPF.GetText().Length != 11)
        {
            CPF.SetValidation(
                "O CPF deve possuir 11 caracteres.", true);
        }

        else
        {
            resultado = true;
            CPF.HideValidation();
        }

        return resultado;
    }


    private bool ValidarEmail(ValidationComponent Email)
    {
        bool resultado = false;

        if (Email.IsEmpty())
        {
            Email.SetValidation("Campo obrigatório", true);
        }

        else if (!Email.GetText().Contains('@'))
        {
            Email.SetValidation(
                "Informe um email válido.", true);
        }

        else
        {
            resultado = true;
            Email.HideValidation();
        }

        return resultado;
    }


    private bool ValidarTelefone(ValidationComponent Telefone)
    {
        bool resultado = false;

        if (Telefone.IsEmpty())
        {
            Telefone.SetValidation("Campo obrigatório", true);
        }

        else if (Telefone.GetText().Length < 10)
        {
            Telefone.SetValidation(
                "Informe um telefone válido.", true);
        }

        else
        {
            resultado = true;
            Telefone.HideValidation();
        }

        return resultado;
    }


    private bool ValidarEmpresa()
    {
        bool resultado = false;

        //Verificar se uma das opções foi selecionada
        if (!rbEmpresaSim.IsChecked && !rbEmpresaNao.IsChecked)
        {
            lblValidationEmpresa.Text =
                "Selecione uma opção.";

            lblValidationEmpresa.IsVisible = true;

            //Aplicar animação no campo
            Animation.Tremer(rbEmpresaSim);
        }
        else
        {
            resultado = true;
            lblValidationEmpresa.IsVisible = false;
        }

        return resultado;
    }


    private bool ValidarSenha(ValidationComponent Senha)
    {
        bool resultado = false;

        if (Senha.IsEmpty())
        {
            Senha.SetValidation("Campo obrigatório", true);
        }

        else if (Senha.GetText().Length < 5)
        {
            Senha.SetValidation(
                "Informe a senha com no mínimo 5 caracteres.", true);
        }

        else if (!Senha.GetText().Any(char.IsDigit))
        {
            Senha.SetValidation(
                "A senha deve possuir pelo menos um número.", true);
        }

        else
        {
            resultado = true;
            Senha.HideValidation();
        }

        return resultado;
    }


    private bool ValidarConfirmarSenha(
        ValidationComponent ConfirmarSenha,
        ValidationComponent Senha)
    {
        bool resultado = false;

        if (ConfirmarSenha.IsEmpty())
        {
            ConfirmarSenha.SetValidation(
                "Campo obrigatório", true);
        }

        else if (ConfirmarSenha.GetText() != Senha.GetText())
        {
            ConfirmarSenha.SetValidation(
                "As senhas não são iguais.", true);
        }

        else
        {
            resultado = true;
            ConfirmarSenha.HideValidation();
        }

        return resultado;
    }


    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new pgLogin());
    }
}