namespace DoAnBanSach.Client.Shared;

public class PriceFormatter
{
    public string Format(decimal price)
    {
        return price.ToString("N0") + " đ";
    }
    public string Format(int price)
    {
        return price.ToString("N0") + " đ";
    }
    public string Format(float price)
    {
        return price.ToString("N0") + " đ";
    }
}
