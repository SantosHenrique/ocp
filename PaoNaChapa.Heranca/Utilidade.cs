using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PaoNaChapa.Heranca
{
    /// <summary>
    /// Container para métodos que podem ser utilizados em mais de um local no projeto
    /// </summary>
    public static class Utilidade
    {
        public static string GetDescricaoEnum(Enum valor)
        {
            FieldInfo campoInfo = valor.GetType().GetField(valor.ToString());
            DescriptionAttribute[] descricoes = (DescriptionAttribute[])campoInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return descricoes.Any() ? descricoes.First().Description.ToString() : "Problemas para exibir esse item do menu. Por favor, contate o responsável";
        }
    }
}
