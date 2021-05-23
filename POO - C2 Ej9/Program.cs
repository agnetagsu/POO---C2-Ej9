using System;

namespace POO___C2_Ej9
{
    class Electrodomestico
    {
        protected decimal preciobase { get; set; }
        protected string color { get; set; }
        protected char consumoenergetico { get; set; }
        protected decimal peso { get; set; }
        
        public const char F = 'F';
        public const decimal preciopordefecto = 100;
        public const string colorpordefecto = "blanco";
        public const decimal pesopordefecto = 5;
        

        public Electrodomestico()
        {
            preciobase = preciopordefecto;
            color = colorpordefecto;
            consumoenergetico = F;
            peso = pesopordefecto;
           
        }
        public Electrodomestico(decimal precio, decimal npeso)
        {
            preciobase = precio;
            color = colorpordefecto;
            consumoenergetico = F;
            peso = npeso;
        }

        public Electrodomestico(decimal precio, string ncolor, char nconsumoenergetico, decimal npeso)
        {
            preciobase = precio;
            color = ncolor;
            consumoenergetico = nconsumoenergetico;
            peso = npeso;
        }

        
        static void Main(string[] args)
        {
            Electrodomestico electro = new Electrodomestico();

            System.Console.WriteLine("Precio: {0}, Color: {1}, Consumo: {2}, Peso: {3}", electro.preciobase, electro.color, electro.consumoenergetico, electro.peso);

        }
    }

}
    
