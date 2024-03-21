namespace DesignPatterns.Command;

public class BankAccountCommand : ICommand
{
    private BankAccount _account;
    private Action _action;
    private decimal _amount;
    private bool _succeeded;

    public BankAccountCommand(BankAccount account, Action action, decimal amount)
    {
        ArgumentNullException.ThrowIfNull(account);
        _account = account;
        _action = action;
        _amount = amount;
    }

    public enum Action
    {
        Deposit, Withdraw
    }

    public void Call()
    {
        switch (_action)
        {
            case Action.Deposit:
                _account.Deposit(_amount);
                _succeeded = true;
                break;
            case Action.Withdraw:
                _succeeded = _account.Withdraw(_amount);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void Undo()
    {
        if (!_succeeded) return;
        switch (_action)
        {
            case Action.Deposit:
                _account.Withdraw(_amount);
                break;
            case Action.Withdraw:
                _account.Deposit(_amount);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}