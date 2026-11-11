public class Product {
    public string Title;
    public double Price;
    public int StockQuantity;

    public Product(string title, double price, int stockQuantity) {
        Title = title;
        Price = price;
        StockQuantity = stockQuantity;
    }

    public void Restock(int amount) {
        if (amount <= 0) {
            return;
        }
        StockQuantity += amount;
    }

    public bool Sell(int amount) {
        if (amount <= 0 || amount > StockQuantity) {
            return false;
        }
        StockQuantity -= amount;
        return true;
    }

    public double CalculateTotalCost(int quantity) {
        if (quantity <= 0) {
            return 0;
        }
        return Price * quantity;
    }

    public string GetProductInfo() {
        return $">>> Товар: {Title} <<<\n" +
               $"Цена за шт.: {Price} руб.\n" +
               $"Остаток на складе: {StockQuantity} шт.";
    }
}
