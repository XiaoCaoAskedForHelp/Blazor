namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<Pizza[]> GetPizzasAsync()
    {
        return new Pizza[]
        {
            new Pizza()
            {
                Name = "The Baconatorizor",
                Description = "It has EVERY kind of bacon",
                Price = 15,
                Vegetarian = true,
                Vegan = true,
            }
        };
    }
}

