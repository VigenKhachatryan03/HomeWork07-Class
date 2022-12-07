using System;

namespace HomeWork07_Class
{
    class Program
    {
        public static int meth(int a , ref int b, in int ca , out int c)
        {
            c = 8;
            a++;
            return a;
        }
        static void Main(string[] args)
        {
            int num = 8;
            int x;
            meth(8, ref num, 10, out x);

            Animal Dog = new Animal();
            Animal Cat = new Animal();
            Animal Bird = new Animal();
            Animal fish = new Animal();
            Car BMW = new Car();


            Dog.life_span = 20;
            Dog.speed = 35;
            Dog.number_feet = 4;
            Dog.sort = "Pidbul";
            Dog.houseHold = "land";
            Dog.name = "Smbo";
            Dog.soundAnim = "Haff";
            Dog.sound();

            Cat.life_span = 10;
            Cat.speed = 12;
            Cat.number_feet = 4;
            Cat.houseHold = "land";
            Cat.name = "Moni";
            Cat.soundAnim = "Miau";
            Cat.sound();

            Bird.life_span = 15;
            Bird.speed = 40;
            Bird.number_feet = 2;
            Bird.houseHold = "Air";
            Bird.soundAnim = "tsiv";
            Bird.sound();

            BMW.motor = "sa";
          

        }
    }
}
