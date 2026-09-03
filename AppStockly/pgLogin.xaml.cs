namespace AppStockly;

public partial class pgLogin : ContentPage
{
    public pgLogin()
    {
        InitializeComponent();
    }

    private void btnEntrar_Clicked(object sender, EventArgs e)
    {
        //Criar os componentes de validação
        ValidationComponent userName =
            new ValidationComponent(txtUserName, lblValidationUserName);

        ValidationComponent email =
            new ValidationComponent(txtEmail, lblValidationEmail);

        ValidationComponent senha =
            new ValidationComponent(txtSenha, lblValidationSenha);


        //Realizar as validações
        bool bUserName = ValidarUserName(userName);
        bool bEmail = ValidarEmail(email);
        bool bSenha = ValidarSenha(senha);


        //Caso alguma validação tenha falhado
        if (!bUserName || !bEmail || !bSenha)
        {
            return;
        }

        //Caso todas as validações sejam aprovadas
        Application.Current.MainPage = new NavigationPage(new MainPage());
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

        else if (UserName.GetText().Any(char.IsWhiteSpace))
        {
            UserName.SetValidation(
                "O User Name não pode possuir espaços.", true);
        }

        else
        {
            resultado = true;
            UserName.HideValidation();
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

        else if (!Email.GetText().Contains("@stockly.com"))
        {
            Email.SetValidation(
                "Informe um email válido.", true);
        }
        else if (!Email.GetText().Contains('.'))
        {
            Email.SetValidation("O email deve conter um domínio válido.", true);
        }     
        else if (Email.GetText() != "admin@stockly.com")
        {
            Email.SetValidation(
                "Email inválido", true);
        }

        else
        {
            resultado = true;
            Email.HideValidation();
        }

        return resultado;
    }


    private bool ValidarSenha(ValidationComponent Senha)
    {
        bool resultado = false;

        if (Senha.IsEmpty())
        {
            Senha.SetValidation("Informe uma senha", true);
        }

        else if (Senha.GetText().Length < 5)
        {
            Senha.SetValidation(
                "Informe a senha com no mínimo 5 caracteres.", true);
        }

        else if (Senha.GetText() != "Admin@123")
        {
            Senha.SetValidation(
                "Senha incorreta", true);
        }

        else
        {
            resultado = true;
            Senha.HideValidation();
        }

        return resultado;
    }


    private void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage =
            new NavigationPage(new pgCadastro());
    }
}