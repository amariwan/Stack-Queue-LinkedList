using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isGited {

    interface IWerkstatt {

    }

    interface IInfo {
        public string Info() {
            return "Wir helfen bei allem";
        }
    }

    interface IAuto : IInfo {
        public string Motor { get; set; }
        public string GetBrand();
        //string Tank { get; set; }
    }

    interface IBenzinAuto : IAuto {
       public string Tank { get; set; }
    }

    interface IElektroAuto : IAuto {
        public string Battery { get; set; }
    }

    interface IWasserstoffAuto : IAuto {
        public string WasserstoffTank { get; set; }
    }

    class Bugatti : IBenzinAuto {
        public string Motor { get; set; } = "V10 Turbo";
        public string Tank { get; set; } = "100L";

        public string Info() {
            return "Benzinauto";
        }

        public string GetBrand() {
            return "Bugatti";
        }

        
    }

    class Ferrari : IBenzinAuto {
        public string Motor { get; set; } = "V8 Benzin";
        public string Tank { get; set; } = "80L";

        public string Info() {
            return "Benzinauto";
        }
        public string GetBrand() {
            return "Ferrari";
        }
    }

    class Koenigsegg : IBenzinAuto {
        public string Motor { get; set; }
        public string Tank { get; set; }

        public  string Info() {
            return "Benzinauto";
        }
        public string GetBrand() {
            return "Koenigsegg";
        }
    }

    class Tesla:IElektroAuto {
        public string Motor { get; set; }
        public string Battery { get; set; }

        public  string Info() {
            return "Elektroauto";
        }
        public string GetBrand() {
            return "Bugatti";
        }
    }

    class Porsche_Taycan:IElektroAuto {
        public string Motor { get; set; }
        public string Battery { get; set; }

        public  string Info() {
            return "Elektroauto";
        }
        public string GetBrand() {
            return "Bugatti";
        }
    }

    class Mercedes_EQS:IElektroAuto {
        public string Motor { get; set; }
        public string Battery { get; set; }

        public string Info() {
            return "Elektroauto";
        }
        public string GetBrand() {
            return "Bugatti";
        }
    }
 

    class  Toyota_Mirai: IWasserstoffAuto {
        public string Motor { get; set; }
        public string WasserstoffTank { get; set; }

        public  string Info() {
            return "Wasserstoffauto";
        }
        public string GetBrand() {
            return "Bugatti";
        }
    }

    class BMW: IWasserstoffAuto {
        public string Motor { get; set; }
        public string WasserstoffTank { get; set; }
        public  string Info() {
            return "Wasserstoffauto";
        }
        public string GetBrand() {
            return "Bugatti";
        }
    }

    class Hyundai:IWasserstoffAuto {
        public string Motor { get; set; }
        public string WasserstoffTank { get; set; }
        public  string Info() {
            return "Wasserstoffauto";
        }
        public string GetBrand() {
            return "Bugatti";
        }
    }




    class Werkstatt<T> where T : IInfo {
        public string Info() {
            return "Allgemeine Wertstatt";
        }



    }

    class BenzinAutoWerkstatt<T> where T : IBenzinAuto {
        public string Info() {
            return "Benzinauto Wertstatt";
        }



        public void Reparieren(T auto) {

            Console.WriteLine(auto.GetBrand());

        }



    }
}
