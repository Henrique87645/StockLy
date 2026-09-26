
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStockly.ViewModels
{
    public class CadLoginViewModel : BaseNotifyViewModel
    {

        //Preço de vendas
        private string _loginName;
        public string LoginName
        {
            get { return _loginName; }
            set
            {
                _loginName = value;
                OnPropertyChanged(nameof(LoginName));
            }
        }

        private string _mensagemValidacaoLoginName;
        public string MensagemValidacaoLoginName
        {
            get { return _mensagemValidacaoLoginName; }
            set
            {
                _mensagemValidacaoLoginName = value;
                OnPropertyChanged();
            }
        }

        private bool _exibirMensagemErroLoginName;
        public bool ExibirMensagemErroLoginName
        {
            get { return _exibirMensagemErroLoginName; }
            set
            {
                _exibirMensagemErroLoginName = value;
                OnPropertyChanged();
            }
        }


        //------------------------------------------------------------------
                                    //Commands
        //------------------------------------------------------------------

        public Command btnCadastrar
        {
            get
            {
                return new Command(() =>
                {
                    ValidarUserName();
                });
            }
        }

        public Command btnEntrar
        {
            get
            {
                return new Command(() =>
                {
                    ValidarUserName();
                    Entrar();
                });
            }
        }




        //------------------------------------------------------------------
                                //Validações
        //------------------------------------------------------------------


        private void Entrar()
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }

        private void ValidarUserName()
        {
            if (string.IsNullOrWhiteSpace(LoginName))
            {
                MensagemValidacaoLoginName = "Campo obrigatório";
                ExibirMensagemErroLoginName = true;
            }

            else if (LoginName.Length < 5)
            {
                MensagemValidacaoLoginName = "O User Name deve ter no mínimo 5 caracteres.";
                ExibirMensagemErroLoginName = true;
            }

            else if (LoginName.Any(char.IsWhiteSpace))  //  HFernandes
            {
                MensagemValidacaoLoginName = "O User Name não pode conter espaços.";
                ExibirMensagemErroLoginName = true;
            }
            else
                ExibirMensagemErroLoginName = false;
        }


        //    private bool ValidarEmail(ValidationComponent Email)
        //    {
        //        bool resultado = false;

        //        if (Email.IsEmpty())
        //        {
        //            Email.SetValidation("Campo obrigatório", true);
        //        }

        //        else if (!Email.GetText().Contains("@stockly.com"))
        //        {
        //            Email.SetValidation(
        //                "Informe um email válido.", true);
        //        }
        //        else if (!Email.GetText().Contains('.'))
        //        {
        //            Email.SetValidation("O email deve conter um domínio válido.", true);
        //        }
        //        else if (Email.GetText() != "admin@stockly.com")
        //        {
        //            Email.SetValidation(
        //                "Email inválido", true);
        //        }

        //        else
        //        {
        //            resultado = true;
        //            Email.HideValidation();
        //        }

        //        return resultado;
        //    }


        //    private bool ValidarSenha(ValidationComponent Senha)
        //    {
        //        bool resultado = false;

        //        if (Senha.IsEmpty())
        //        {
        //            Senha.SetValidation("Informe uma senha", true);
        //        }

        //        else if (Senha.GetText().Length < 5)
        //        {
        //            Senha.SetValidation(
        //                "Informe a senha com no mínimo 5 caracteres.", true);
        //        }

        //        else if (Senha.GetText() != "Admin@123")
        //        {
        //            Senha.SetValidation(
        //                "Senha incorreta", true);
        //        }

        //        else
        //        {
        //            resultado = true;
        //            Senha.HideValidation();
        //        }

        //        return resultado;
        //    }
    }
}
