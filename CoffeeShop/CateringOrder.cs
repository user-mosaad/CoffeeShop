class CateringOrder : Order
{
    public int MinimumGuests { get; }
    public string? ApprovedBy { get; private set; }

    public CateringOrder(int minimumGuests) => MinimumGuests = minimumGuests;

    public void Approve(string manager) => ApprovedBy = manager;

    public override string Status
    {
        get => base.Status;
        set
        {
            if (value == "Ready" && ApprovedBy is null)
                throw new InvalidOperationException(
                    "A catering order requires manager approval before it can be marked ready.");
            base.Status = value;
        }
    }

    public override string ToString() =>
        $"Catering [{Status}] for {MinimumGuests}+ guests, approved by: {ApprovedBy ?? "(none)"} - Total: {Total:F2}";
}
