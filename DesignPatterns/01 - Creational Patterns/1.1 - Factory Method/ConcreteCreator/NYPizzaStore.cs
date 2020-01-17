using System;
using System.Collections.Generic;
using System.Text;
using ConcreteProduct;
using Creator;
using DesignPatterns.Factory_Method.Util;
using Product;

namespace ConcreteCreator
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(EnumTypePizza type)
        {
            if (type == EnumTypePizza.cheese)
            {
                return new NYStyleCheesePizza();
            }
            else
            {
                return null;
            }
        }
    }
}
