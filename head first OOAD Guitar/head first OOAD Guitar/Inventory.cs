using System;
using System.Collections.Generic;
using System.Text;

namespace head_first_OOAD_Guitar
{
    class Inventory
    {
        private List<object> guitars;
        public Inventory()
        {
            guitars = new List<object>();
        }
        public void addGuitar(String serialNumber, double price, GuitarSpec spec)
        {
            Guitar guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }
        public Guitar getGuitar(String serialNumber)
        {
            int index = 0;
            foreach(var i in guitars)
            {
                Guitar guitar = (Guitar)guitars[index];
                if (guitar.getSerialNumber().Equals(serialNumber))
                {
                    return guitar;
                }
                index++;
            }
            return null;
        }

        public List<object> search(GuitarSpec searchSpec)
        {
            List<object> matchingGuitars = new List<object>();
            int index = 0;
            foreach(var i in guitars)
            {
                Guitar guitar = (Guitar)guitars[index];
                if(guitar.GetSpec().matches(searchSpec))
                    matchingGuitars.Add(guitar);
                index++;
            }
            return matchingGuitars;
        }
    }
}
