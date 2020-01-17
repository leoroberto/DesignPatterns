using System;
using System.Collections.Generic;
using System.Text;
using ConcreteProduct;
using Creator;
using DesignPatterns.Factory_Method.Util;
using Product;

namespace ConcreteCreator
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(EnumTypePizza type)
        {
            if (type == EnumTypePizza.cheese)
            {
                return new ChicagoStyleCheesePizza();
            }
            else
            {
                return null;
            }
        }
    }
}
