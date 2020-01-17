using System;
using System.Collections.Generic;

namespace Product
{
    public abstract class Pizza
    {
        public string name { get; set; }
        public string dough { get; set; }
        public string sauce { get; set; }
        public List<string> toppings { get; set; }

        public void Prepare()
        {
            Console.WriteLine("Preparando " + name);
            Console.WriteLine("Amassando a massa...");
            Console.WriteLine("Adicionando o molho...");
            Console.WriteLine("Adicionando as coberturas...");
            foreach (var t in toppings)
            {
                Console.WriteLine("   " + t);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Assar por 25 minutos a 350º");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cortar a pizza em fatias diagonais");
        }

        public virtual void Box()
        {
            Console.WriteLine("Colocar a pizza na caixa oficial da pizzaria");
        }
    }
}