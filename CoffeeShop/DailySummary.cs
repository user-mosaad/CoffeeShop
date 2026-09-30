record class DailySummary(int TotalOrders, decimal Revenue)
{
    public decimal AverageTicket => TotalOrders > 0 ? Revenue / TotalOrders : 0m;
}
