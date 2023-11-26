namespace Domain.Entities;

public class User : Base
{
    public User(string firstName, string lastName, string email, double salary, string? phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Salary = salary;
        PhoneNumber = phoneNumber;
        Expenses = new List<Expense>();
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public double Salary { get; set; }
    public string? PhoneNumber { get; set; }
    public ICollection<Expense> Expenses { get; set; }
    public Guid? WalletId { get; set; }
    public Wallet? Wallet { get; set; }
}