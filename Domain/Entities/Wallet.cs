using Ardalis.GuardClauses;
using Domain.Enums;

namespace Domain.Entities
{
    public class Wallet : Base
    {
        public Wallet(Guid userId, double balance)
        {
            UserId = userId;
            Balance = balance;
            Cards = new List<Card>();
        }

        public List<Card> Cards { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public double Balance { get; private set; }

        public double UpdateBalance(double value, EBalanceOperation operation)
        {
            Guard.Against.NegativeOrZero(value);

            if (operation.Equals(EBalanceOperation.ADD))
            {
                Balance += value;
                return Balance;
            }

            if (operation.Equals(EBalanceOperation.DECREASE))
            {
                Balance -= value;
            }

            return Balance;
        }
    }
}
