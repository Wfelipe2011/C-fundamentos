using System;
using System.Collections.Generic;
using System.Text;

namespace NotaAluno
{
    class Media
    {
        
        public static double NotaMedia(double a , double b , double c)
        {
            double media = a + b + c;
            return media;
        }

        public static string Situacao(double media)
        {
            string situacao;
            if (media >= 60)
            {
                situacao = "APROVADO!";
            }
            else
            {
                situacao = "Reprovado!";
            }
            return situacao;
        }
    }
}
