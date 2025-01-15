using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationOOPProject
{
    internal class Car
    {
        public string Marka { get; set; }

        public int Model {  get; set; } 
       
        public string Renk { get; set; }

        int _kapiSayisi;

        public int KapıSayisi {

            get
            {
                return _kapiSayisi;


            }

            set
            {
                if (value != 4 && value != 2)
                {
                    Console.WriteLine("\nKapı sayısı 4 ve 2 den farklı olamaz !\n");

                    _kapiSayisi = -1;
                }

               else
                {
                    _kapiSayisi = value;
                }
            } 
        
        
        
        }




    }
}
