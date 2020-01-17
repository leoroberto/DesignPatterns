using System;
using DesignPatterns.Factory_Method.Util;
using Product;

namespace Creator
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(EnumTypePizza type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(EnumTypePizza type);
    }
}