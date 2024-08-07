
namespace SloppyJoe;

class MenuItem
{
    public string[] Proteins = [
        "Roast beef", "Salami", "Turkey",
        "Ham","Pastrami", "Tofu"
        ];

    public string[] Condiments = [
        "yellow mustard", "brown mustard",
        "honey mustard", "mayo", "relish", "French dressing"
        ];

    public string[] Breads = ["rye", "white", "wheat", "pumpernickel", "a roll"];

    public string Description = "";
    public string Price = "";

    public void Generate()
    {
        string protein = this.Proteins[GetRandomIndex(this.Proteins.Length)];
        string condiment = this.Proteins[GetRandomIndex(this.Condiments.Length)];
        string bread = this.Proteins[GetRandomIndex(this.Breads.Length)];

        this.Description = protein + " with " + condiment + "on" + bread;

        int randomInt = Random.Shared.Next(5, 15);
        int randomPartDecimal = Random.Shared.Next(100);
        Decimal cents = randomPartDecimal * .01M;
        Decimal price = randomInt * cents;
        this.Price = price.ToString("c");


    }

    public int GetRandomIndex(int index)
    {
        return Random.Shared.Next(0, index);
    }
}
