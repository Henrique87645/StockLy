using System;
using System.Collections.Generic;
using System.Text;

namespace AppStockly
{
    public static class Animation
    {
        static public async void Tremer(VisualElement elemento)
        {
            //Validar caso o componente esteja nulo
            if (elemento == null)
                return; //aborta a execução

            //Definir um tempo padrão de animação
            uint tempo = 50;

            //Listar os deslocamento
            //Colocar na ordem que deseja a animação
            var deslocamentos =
                new[] { -15, 15, -10, 10, -5, 5 };

            //Loop que ira ler cada deslocamento
            //e aplicar a animação
            foreach (var movimento in deslocamentos)
            {
                //Primeiro é movimento em pixel horizontal
                //Segundo é movimento em pixel vertical
                //Terceiro tempo da animação
                await elemento.TranslateTo(movimento, 0, tempo);
            }
            //Por ultimo reseta o movimento em x
            elemento.TranslationX = 0;
        }
    }
}
