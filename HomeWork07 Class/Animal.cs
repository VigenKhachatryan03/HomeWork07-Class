using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork07_Class
{
    class Animal
    {
        public int number_feet;
        public float speed;
        public int life_span;
        public string sort;
        public string name;
        public string houseHold;
        public string soundAnim;



        public void sound()
        {
            Console.WriteLine($"{soundAnim}... {soundAnim}....... {soundAnim}...........");
        }


    }
}
