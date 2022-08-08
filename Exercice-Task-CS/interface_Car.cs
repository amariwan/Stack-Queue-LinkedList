using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Task_CS {

    interface Werkstatt {

    }

    interface IInfo {
        public string Info() {
            return "Wir helfen bei allem";
        }
    }

    interface IAuto : IInfo {
        public string Motor { get; set; }
        public string GetBrand();
        public bool MotorOn();
        //public void GasGeben();
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

    interface IHybridAuto : IBenzinAuto, IElektroAuto {

    }

    class Bugatti : IBenzinAuto {
        public string Motor { get; set; } = "V10 Turbo";
        public string Tank { get; set; } = "100L";

        public bool MotorOn() {
            // Benzin Hahn auf
            // Zuendung
            // Motor andrehen
            return true;
        }

        public string Info() {
            return "Benzinauto";
        }

        public string GetBrand() {
            return "Bugatti";
        }
    }
    
    class Tesla:IElektroAuto {
        public string Motor { get; set; }
        public string Battery { get; set; }

        public bool MotorOn() {
            // so tun als ob man ihn anschalten muss
            return true;
        }

        public  string Info() {
            return "Elektroauto";
        }
        public string GetBrand() {
            return "Tesla";
        }
    }
    class BMW: IHybridAuto {
        public string Motor { get; set; }
        public string Tank { get; set; }
        public string Battery { get; set; }
        public  string Info() {
            return "Wasserstoffauto";
        }
        public string GetBrand() {
            return "Bugatti";
        }

        public bool MotorOn() {
            // Wasserstoff Hahn auf
            // Zuendung
            // Motor andrehen
            return true;
        }
    }

    class BMW_3er : BMW {

    }

    class BMW_5er : BMW {

    }
 
    class BenzinAutoWerkstatt<T> where T : IBenzinAuto {

        private bool CheckAuto(T info) {

            return false;
        }
        private bool CheckMotor(T auto) {
            auto.MotorOn();
            //auto.GasGeben();

            return false;
        }

        


        public string Info() {
            return "Benzinauto Wertstatt";
        }

        public void Reparieren(T auto) {
            Console.WriteLine(auto.GetBrand());

        }
    }

    class ElektroAutoWerkstatt<T> where T : IElektroAuto {

        public bool Join(string Auto) {
            if (CheckAuto(Auto)) {
                return true;
            }
            return false;
        }

        private bool CheckAuto(string info) {

            return false;
        }

        public string Info() {
            return "ElektroAuto Wertstatt";
        }

        public void Reparieren(T auto) {

            Console.WriteLine(auto.GetBrand());

        }
    }

    class WasserstoffAutoWerkstatt<T> where T : IWasserstoffAuto {
        public bool Join(string Auto) {
            if (CheckAuto(Auto)) {
                return true; 
            }
            return false;
        }

        private bool CheckAuto(string info) {
            
            return false; 
        }

        public string Info() {
            return "Wasserstoff Wertstatt";
        }

        public void Reparieren(T auto) {

            Console.WriteLine(auto.GetBrand());

        }
    }

    class Werkstatt<T> where T :IAuto {
        public void Reparieren(T auto) {
            auto.GetBrand();
            auto.MotorOn();
        }
    }
}
