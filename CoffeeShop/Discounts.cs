interface IDiscountPolicy
{
    decimal Apply(decimal total);
}

class HappyHourDiscount : IDiscountPolicy
{
    public decimal Apply(decimal total) => total * 0.80m;
}

class LoyaltyDiscount : IDiscountPolicy
{
    public decimal Apply(decimal total) => total - 1.00m;
}
