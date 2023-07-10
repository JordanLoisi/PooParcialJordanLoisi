using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooParcial.Entidades
{
    public class Cono
    {
        private double generatriz;


        private double altura;


        private double radio;

        public double Generatriz
        {
            get { return generatriz; }
        }

        public double Altura
        {
            get { return altura; }
        }

        public double Radio
        {
            get { return radio; }
        }

        public Cono(double altura, double radio)
        {
            if (altura <= 0 || radio <= 0)
            {
                {
                    Console.WriteLine("La altura y el radio deben ser mayores que cero.");
                }

            }

            this.altura = altura;


            this.radio = radio;
            this.generatriz = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(radio, 2));
        }

       



        public double GetArea()
        {
            return Math.PI * radio * (radio + generatriz);
        }

        public double CalcularVolumen()
        {
            return Math.PI * Math.Pow(radio, 2) * (altura / 3);

        }
    }
}

        


        

     
                
              



           

                  





               
