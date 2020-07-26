using System.Linq;

namespace PG.Validador
{
    public class Cedula : IValidador
    {
        private readonly string cedula;

        public Cedula(string cedula)
        {
            this.cedula = cedula;
        }
        /// <summary>
        /// Algoritmo de Lugh
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public bool Valida()
        {
            int sumatoria = 0;
            int index = 0;

            var verificador = int.Parse(cedula.Substring(cedula.Length - 1, 1));

            cedula.Substring(0, cedula.Length - 1).ToList().ForEach(v =>
           {
               ++index;

               bool indexPar = (index % 2 <= 0);

               var valor = int.Parse(v.ToString());


               if (indexPar)
               {
                   var mResult = valor * 2;

                   if (mResult > 9) mResult -= 9;

                   sumatoria += mResult;
               }
               else
               {
                   sumatoria += valor;
               }



           });

            var _result = sumatoria * 9 % 10;

            return (verificador == _result);


        }

    }


}
