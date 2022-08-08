using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isGited {
    class LinkedList {

        Item Item = null;

        public void Add(string value) {
            Item it = new Item();
            it.D = value;
            it.V = Item;
            
            Item = it;
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
        public string Get(string value) {

            Item temp = Item;

            while (temp != null) {

                if (temp.D == value) {
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
        public Item V = null;

    }
}

