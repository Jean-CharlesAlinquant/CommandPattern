using DesignPatterns.Command;

var ba = new BankAccount();
var commands = new List<BankAccountCommand>
{
    new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100),
    new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 50)
};

Console.WriteLine(ba);

foreach (var command in commands)
{
    command.Call();
}
Console.WriteLine(ba);

foreach (var command in Enumerable.Reverse(commands))
{
    command.Undo();
}
Console.WriteLine(ba);