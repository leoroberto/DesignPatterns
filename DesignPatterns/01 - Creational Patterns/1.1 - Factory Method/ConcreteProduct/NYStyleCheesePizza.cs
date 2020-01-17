using System.Collections.Generic;
using Product;

namespace ConcreteProduct
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "Pizza de molho e queijo estilo NY";
            dough = "Massa fina";
            sauce = "Molho Marinara";

            toppings = new List<string>();
            toppings.Add("Queijo Reggiano Ralado");
        }
    }
}