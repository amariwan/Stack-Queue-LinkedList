using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Task_CS {
    class LinkedList {

        Item Item = null;
        public int i = 0;
        public int Add(string value) {
            Item it = new Item();
            it.D = value;
            it.I = i;
            it.V = Item;
            Item = it;
            return it; 
        }

        public bool Remove(string value) {
            Item temp = Item;
            Item last = Item;
            
            while (temp != null) {

                if (temp.D == value) {
                    last.V = temp.V;
                    return true;
                }
                last = temp;
                temp = temp.V;
            }
            return false;
        }
        public string Get(int index) {

            Item temp = Item;

            while (temp != null) {

                if (temp.I == index) {
                    return temp.D;
                }
                temp = temp.V;
            }
            return "leer";
        }
        public string Gets() {
            Item temp = Item;

            while (temp != null) {
                Console.WriteLine(temp.D);
                temp = temp.V;
            }
            return "leer";
        }
    }

    class Item {
        public string D = null;
        public int I = 0;
        public Item V = null;

    }
}

