class AnimalFeedVendingMachine : VendingMachine
{
    public override string Item
    {
        get { return "a handful of animal feed"; }
    }

    protected override bool CheckAmount(decimal money)
    {
        return money >= 1.25M;
    }
}