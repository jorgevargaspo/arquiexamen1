using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SolucionExamenCleanCode
{
    internal static class Validaciones
    {
        public static bool EsNitValido(long nit)
        {
            //if (nit>=1000000 && nit<=9999999999)
            //{
            //    return true;
            //}

            //return false;
            return (nit >= 1000000 && nit <= 9999999999)?true:false;

        }

        public static bool EsRazonSocialValida(string razonSocial)
        {
            
            if (razonSocial != razonSocial.Trim())
            {
                return false;
            }
            razonSocial = razonSocial.Trim();
            for (int i = 0; i < razonSocial.Length; i++) {
                if (!Char.IsLetter(razonSocial[i]) && razonSocial[i]!=' ')
                {
                    return false;
                }
                if (razonSocial[i]==' ' && razonSocial[i+1]==' ')
                {
                    return false;
                }            
            }

            return true;

        }


    }
}
