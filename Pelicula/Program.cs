using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        public static void Main(string[] args) { }
        private string Titulo { get; set; }
        private Int16 Año { get; set; }
        private string País { get; set; }
        private string Director { get; set; }
        private List<Actor> actores = new List<Actor>();

        //Constructores

        public Pelicula(){}
        public Pelicula(string titulo,Int16 año, string pais, string director)
        {
            Titulo = titulo;
            Año = año;
            País = pais;
            Director = director;
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
