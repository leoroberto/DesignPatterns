using ConcreteCreator;
using System;
using ConcreteProduct;
using Xunit;
using DesignPatterns.Factory_Method.Util;

namespace Teste.DesignPatterns
{
    public class UnitTest1
    {
        [Fact]
        public void DadoUmaNYPizzariaStore_QuandoCriarPizza_DeveRetornarObjetoPizzaCorreto()
        {
            //Arrange
            var pizzaNYStore = new NYPizzaStore();

            //Act
            var pizzaCheese = pizzaNYStore.orderPizza(EnumTypePizza.cheese);

            //Assert
            Assert.NotNull(pizzaNYStore);
            Assert.NotNull(pizzaCheese);
            Assert.IsType<NYStyleCheesePizza>(pizzaCheese);
        }

        [Fact]
        public void DadoUmaChigagoPizzariaStore_QuandoCriarPizza_DeveRetornarObjetoPizzaCorreto()
        {
            //Arrange
            var pizzaChicagoStore = new ChicagoPizzaStore();

            //Act
            var pizzaCheese = pizzaChicagoStore.orderPizza(EnumTypePizza.cheese);

            //Assert
            Assert.NotNull(pizzaChicagoStore);
            Assert.NotNull(pizzaCheese);
            Assert.IsType<ChicagoStyleCheesePizza>(pizzaCheese);
        }
    }
}
