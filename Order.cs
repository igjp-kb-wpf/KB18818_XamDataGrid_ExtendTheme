namespace XamDataGrid_ExtendTheme;

/// <summary>
/// グリッドに表示するデモ用の受注データ。
/// </summary>
public class Order
{
    public required int OrderId { get; init; }
    public required string Customer { get; init; }
    public required string Product { get; init; }
    public required int Quantity { get; init; }
    public required decimal Amount { get; init; }
    public required string Status { get; init; }
}
