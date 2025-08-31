namespace DesignPattern.BuilderPattern;

public class PreparedAlcoholicDrinkConcreteBuilder: IBuilder
{
    private PreparedDrink _preparedDrink;

    public PreparedAlcoholicDrinkConcreteBuilder()
    {
        Reset();
    }
    
    public void Reset()
    {
        _preparedDrink = new PreparedDrink();
    }

    public void SetAlcohol(decimal alcohol)
    {
        _preparedDrink.Alcohol = alcohol;
    }

    public void SetWater(int water)
    {
        _preparedDrink.Water = water;
    }

    public void SetMilk(int milk)
    {
        _preparedDrink.Milk = milk;
    }

    public void AddIngredients(string ingredients)
    {
        if (_preparedDrink.Ingredients == null)
        {
            _preparedDrink.Ingredients = new List<string>();
        }
        
        _preparedDrink.Ingredients.Add(ingredients);
        
    }

    public void Mix()
    {
        string ingredients = _preparedDrink.Ingredients.Aggregate((i, j) => i + ", " + j);
        _preparedDrink.Result = $"Bebida preparada con {_preparedDrink.Alcohol} de alcohol " +
                                $"con los siguientes ingredientes: {ingredients}";
        Console.WriteLine("Mezclamos los ingredientes");
    }

    public void Rest(int time)
    {
        Thread.Sleep(time);
        Console.WriteLine("Listo para beberse");
    }
    
    public PreparedDrink GetPreparedDrink()
    {
        return _preparedDrink;
    }
}