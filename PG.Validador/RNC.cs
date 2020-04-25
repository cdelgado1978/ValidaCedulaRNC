using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace PG.Validador
{

    public class RNC : IValidador
    {

        private List<char> rnc;
        private int verificador;

        public RNC(string rnc)
        {
            this.rnc = rnc.Substring(0, rnc.Length -1 ).ToList();
            this.verificador = int.Parse(rnc.Substring(rnc.Length - 1, 1));
        }

        public bool Valida()
        {

            var factor =  new List<int>() { 2,3,4,5,6,8,9,7 };
            var index = 0;
            var sumatoria = 0;

            rnc.Reverse();

            rnc.ForEach(v => {

                

                var v1 = int.Parse(v.ToString());
                var fx = factor[index];

                sumatoria += v1 * fx;

                if (index == 7)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }

            });

            var residuo = sumatoria % 11;

            var resultado = 11 - residuo;

            var checkDigit = (resultado < 10 ) ? resultado :  (resultado > 10) ? 0 : 1;

            return (verificador == checkDigit);

        }
    }


}
