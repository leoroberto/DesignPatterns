namespace DesignPatterns._1
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "Pizza de molho e queijo estilo NY";
            dough = "Massa fina";
            sauce = "Molho Marinara";

            toppings.Add("Queijo Reggiano Ralado");
        }
    }
}