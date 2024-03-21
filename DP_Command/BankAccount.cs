namespace DesignPatterns.Command;

public class BankAccount
{
    private decimal _balance;
    private decimal _overdraftLimit = -500m;

    internal void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"Deposited ${amount}, balance is now {_balance}");
    }

    internal bool Withdraw(decimal amount)
    {
        if (_balance - amount >= _overdraftLimit)
        {
            _balance -= amount;
            Console.WriteLine($"Withdrew ${amount}, balance is now {_balance}");
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"{nameof(_balance)}: {_balance}";
    }
}
