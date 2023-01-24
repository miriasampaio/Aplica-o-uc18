using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicaçãoDeTestes
{
    internal class desenhoDeTesteImc
    {
        public static string CalculoImc(double kg, double altura)
        {
            double resultado = kg / (altura * altura);

            if (resultado < 18.5)
            {
                return "Abaixo do Peso";
            }

            if (resultado < 24.9)
            {
                return "Peso Normal";
            }

            if (resultado < 29.9)
            {
                return "Sobrepeso";
            }

            if (resultado < 34.9)
            {
                return "Obesidade grau I";
            }

            if (resultado < 39.9)
            {
                return "Obesidade grau II";
            }
            else
            {
                return "Obesidade grau III";
            }
        }
    }
}
