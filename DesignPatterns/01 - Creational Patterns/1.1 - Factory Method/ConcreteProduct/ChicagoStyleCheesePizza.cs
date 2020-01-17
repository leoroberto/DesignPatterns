using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Product;

namespace ConcreteProduct
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Pizza de queijo de prato fundo estilo Chicago";
            dough = "Massa Crosta Extra Grosso";
            sauce = "Molho de Tomate Ameixa";
            toppings = new List<string>();
        }
    }
}