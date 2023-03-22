using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        public static void Main(string[] args) { }
        public int titulo { get; set; }
        public Int16 año { get; set; }
        public string País { get; set; }
        public string Director { get; set; }
        private List<Actor> actores = new List<Actor>();

        //Constructores

        public Pelicula(){}
        public Pelicula(string titulo, Int16 año)
        {
            this.Titulo = Titulo;
            this.año = año;
            this.País = País;
            this.Director = Director;
        }
     
        //Métodos

        public string getTitulo()
        {
            return titulo;
        }
     
        public void Imprime()
        {
     //       Console.WriteLine($"{titulo} ({año})");

        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}
