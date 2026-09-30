class Order : IOrder
{
    public virtual string Status { get; set; }
    private readonly List<(string Name, decimal Price)> _items = [];
    public void AddItem(string name, decimal price) => _items.Add((name, price));

    public decimal Total => _items.Sum(i => i.Price);

    public override string ToString() => $"Order [{Status}]: {string.Join(", ", _items.Select(i => i.Name))} - Total: {Total:F2}";
}
