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
        private string Pais { get; set; }
        private string Director { get; set; }
        public string V1 { get; set; }
        public int V2 { get; set;}

        private List<Actor> actores = new List<Actor>();
        

        //Constructores

        public Pelicula(){}
        public Pelicula(string titulo,Int16 año, string pais, string director)
        {
            Titulo = titulo;
            Año = año;
            Pais = pais;
            Director = director;
        }

        public Pelicula(string v1, int v2)
        {
            V1 = v1;
            V2 = v2;
        }



        //Métodos

        public string getTitulo()
        {
            return Titulo;
        }
        public Int16 getAño()
        {
            return Año;
        }
        public string getPais()
        {
            return Pais;
        }
        public string getDirector()
        {
            return Director;
        }
        public void SetTitulo(string titulo)
        {
            Titulo = Titulo;
        }
        public void SetAño(Int16 año)
        {
            Año = Año;
        }
        public void SetPais()
        {
            Pais = Pais;
        }
        public void SetDirector()
        {
            Director = Director;
        }
        public void Imprime()
        {
            Console.WriteLine($"{Titulo} ({Año})"); 

        }

        public void AgregaActor(Actor actor) => actores.Add(actor);

        public void ImprimeActores() 
        {
            foreach (Actor actor in actores)
            {
                Console.WriteLine($"{actor.getNombre()} ({actor.getPelicula()})");
            }
        }

        public void SetAño(string año) => this.Año = Año;
    }

    public class Actor
    {
        //Propiedades
        public string Nombre;
        public string Pelicula;
        public int Año;


        //Constructores

        public Actor(int año) => this.Año = Año;
        public Actor (string nombre, string pelicula, int año)
        {
            nombre = Nombre;
            pelicula = Pelicula;
            año = Año;
        }

        

        //Métodos 

        public string getNombre()
        {
            return Nombre;
        }
        public string getPelicula()
        {
            return Pelicula;
        }
        public void SetNombre() => Nombre = Nombre;
        public void SetPelicula() => Pelicula = Pelicula;


        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Pelicula})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {   
        static void Main(string[] args)
        {
            

            Pelicula p1 = new Pelicula();

            p1.SetTitulo("La La Land");

            p1.SetAño("2016");

            Console.WriteLine("{0}({1})", p1.getTitulo(), p1.getAño());

            p1.AgregaActor(new Actor("Ryan Gosling", 1980));

            p1.AgregaActor(new Actor("Emma Stone", 1988));

            p1.ImprimeActores();


        }
    }
}
