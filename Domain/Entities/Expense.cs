using Domain.Enums;

namespace Domain.Entities;

public class Expense : Base
{
    public Expense(int value, DateTime? dueDate, EPaymentMethods paymentMethod, string? description, DateTime purchaseDate, Card? card, int installments, EExpenseStatus status)
    {
        Value = value;
        DueDate = dueDate;
        EPaymentMethod = paymentMethod;
        Description = description;
        PurchaseDate = purchaseDate;
        Card = card;
        Installments = installments;
        Status = status;
    }

    public int Value { get; set; }
    public DateTime? DueDate { get; set; }
    public EPaymentMethods EPaymentMethod { get; set; }
    public string? Description { get; set; }
    public DateTime PurchaseDate { get; set; }
    public Card? Card { get; set; }
    public int Installments { get; set; }
    public EExpenseStatus Status { get; set; }
}
