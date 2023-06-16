using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFCalculator2023
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calc" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calc.svc or Calc.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Calc : ICalc
    {
        static decimal res = 0.0M;
        static string izraz = "";

        //private ICalcCallback callback; OVO JE ZA PERSESSION
        private List<ICalcCallback> callbacks; // ZA SINGLE, SVE OSTALE KLIJENTE NOTIFIKUJE!!

        protected List<ICalcCallback> Callback //ZA SINGLE, DA NOTIFY-UJE OSTALE!
        {
            get
            {
                setCallbacks();
                return callbacks;              
            }
        }

        private void setCallbacks()
        {
            var c = OperationContext.Current.GetCallbackChannel<ICalcCallback>(); //!!!!

            if (!callbacks.Contains(c))
                callbacks.Add(c);
        }

        public Calc()
        {
            //callback = OperationContext.Current.GetCallbackChannel<ICalcCallback>();
            callbacks = new List<ICalcCallback>(); 

        }

        public void Dodaj(decimal a)
        {
            res += a;
            izraz += $" + {a}";

            //ZA SINGLE, DA NOTIFY-UJE SVE OSTALE
            Callback.ForEach(x => x.Rezultat(new Rezultat()
            {
                Res = res,
                Izraz = izraz
            }));

            /* SERVER NE CIMA DRUGE KLIJENTE
             
            callback.Rezultat(new Rezultat()
            {
                Res = res,
                Izraz = izraz

            }); ;
            */
        }


        public void Oduzmi(decimal a)
        {
            res -= a;
            izraz += $" - {a}";

            //NOTIFY-UJE SVE OSTALE
            Callback.ForEach(x => x.Rezultat(new Rezultat()
            {
                Res = res,
                Izraz = izraz
            }));

            /* PER SESSION, SERVER NE CIMA DRUGE KLIJENTE
             
            callback.Rezultat(new Rezultat()
            {
                Res = res,
                Izraz = izraz

            }); ;
            */
        }
        public void Pomnozi(decimal a)
        {
            res *= a;
            izraz += $" * {a}";

            //ZA SINGLE, DA NOTIFY-UJE SVE OSTALE
            Callback.ForEach(x => x.Rezultat(new Rezultat()
            {
                Res = res,
                Izraz = izraz
            }));

            /* PER SESSION, SERVER NE CIMA DRUGE KLIJENTE
             
            callback.Rezultat(new Rezultat()
            {
                Res = res,
                Izraz = izraz

            }); ;
            */
        }

        public void Podeli(decimal a)
        {
            if(a == 0.0M)
            {
                izraz = "Deljenje nulom!!";
                res = 0;
            }
            else
            {
                res /= a;
                izraz += $" / {a}";
            }

            //ZA SINGLE, DA NOTIFY-UJE SVE OSTALE
            Callback.ForEach(x => x.Rezultat(new Rezultat()
            {
                Res = res,
                Izraz = izraz
            }));


            /* PER SESSION, SERVER NE CIMA DRUGE KLIJENTE

             callback.Rezultat(new Rezultat()
             {
                 Res = res,
                 Izraz = izraz

             }); ;
             */

        }

        public Rezultat DodajBezKolbeka(decimal a)
        {
            res += a;
            izraz += $" + {a}";

            return new Rezultat()
            {
                Res = res,
                Izraz = izraz

            };

        }

        public void Register()
        {
            setCallbacks(); //!!!!!!
        }
    }
}
