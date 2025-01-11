using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Car
    {
        //Fieldları tanımlıyoruz. Bizden sadece  kapı sayısını kapsüllememiz istendiği için onun erişim belirleyicisini private yapıyoruz.
        public string brand;
        public string model;
        public string color;
        private int _numberOfDoor;

        //Property alanında sadece kapı sayısını yazıyoruz çünkü diğer değişkenlere dışarıdan erişime izin var.
        public int NumberOfDoor
        {
            get { return _numberOfDoor; }


            set
            {
                if (value == 2 || value == 4)
                {
                    _numberOfDoor = value;
                }
                else
                {
                    _numberOfDoor = -1;
                }
            }
        }
        //Parametreli Constructor ile marka, model, renk ve kapı sayısını girmeden girişe izin vermiyoruz.
        public Car(string brand, string model, string color, int numberOfDoor)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
            NumberOfDoor = numberOfDoor;
        }

        //Oluşturulan nesneleri gösteren metod.
        public void DisplayCar()
        {
            Console.WriteLine($" Aracın Markası : {brand}" +
                              $"\n Aracın Modeli : {model}" +
                              $"\n Aracın Rengi: {color}" +
                              $"\n Aracın Kapı Sayısı: {NumberOfDoor}" +
                              $"\n                                   " +
                              $"\n-----------------------------------" +
                              $"\n                                   ");
        }
    }
}
