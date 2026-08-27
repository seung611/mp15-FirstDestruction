namespace mp15_FirstDestruction;

public class Item
{
    private string name;
    Item[] items = new Item[10];
    private int count = 0;
    
    public int Count { get { return count; } }
    
    public string Name { get; set; }

    public Item(string name)
    {
        Name = name;
    }

    public void Add(Item item)
    {
        items[count] = item;
        count++;
    }

    public void PrintItemName(int index)
    {
        Console.WriteLine(items[index].Name);
    }
}