using Ardalis.GuardClauses;
using Domain.Enums;
using Newtonsoft.Json.Linq;

namespace Domain.Entities;

public class Card : Base
{
    public Card(string description, double limit, DateTime expireDate, string? additionalInformation)
    {
        Description = description;
        Limit = limit;
        ExpireDate = expireDate;
        AdditionalInformation = additionalInformation;
    }

    public string Description { get; set; }
    public double Limit { get; set; }
    public DateTime ExpireDate { get; set; }
    public string? AdditionalInformation { get; set; }

    public void UpdateCardLimit(double value, EBalanceOperation operation)
    {
        Guard.Against.NegativeOrZero(value);

        if (operation.Equals(EBalanceOperation.ADD))
        {
            Limit += value;
        }

        if (operation.Equals(EBalanceOperation.DECREASE))
        {
            Limit -= value;
        }
    }
}