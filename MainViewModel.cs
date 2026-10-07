namespace XamDataGrid_ExtendTheme;

/// <summary>
/// 標準テーマ側・拡張テーマ側の2つのグリッドが同じデータを表示できるよう、
/// 共通の受注一覧を公開するだけのシンプルなViewModel。
/// </summary>
public class MainViewModel
{
    public IReadOnlyList<Order> Orders { get; } = CreateOrders();

    private static List<Order> CreateOrders()
    {
        var customers = new[] { "山田商事", "佐藤工業", "鈴木物産", "高橋電機", "田中製作所", "伊藤運輸" };
        var products = new (string Name, decimal UnitPrice)[]
        {
            ("ノートPC", 148000m),
            ("モニター", 36000m),
            ("キーボード", 8500m),
            ("マウス", 4200m),
            ("ドッキングステーション", 24800m),
            ("Webカメラ", 9800m),
        };
        var statuses = new[] { "受注", "出荷済", "請求済", "完了" };

        // 実行のたびに同じ並びになるよう、乱数のシードを固定している。
        var random = new Random(42);
        var orders = new List<Order>();

        for (var i = 1; i <= 40; i++)
        {
            var product = products[random.Next(products.Length)];
            var quantity = random.Next(1, 11);

            orders.Add(new Order
            {
                OrderId = 1000 + i,
                Customer = customers[random.Next(customers.Length)],
                Product = product.Name,
                Quantity = quantity,
                Amount = product.UnitPrice * quantity,
                Status = statuses[random.Next(statuses.Length)],
            });
        }

        return orders;
    }
}
