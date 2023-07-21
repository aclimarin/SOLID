using ISP.Initial;

namespace Runners.Initial;

public class ISPInitialRunner : IRunner
{
    public void Run()
    {
        BankAccount bankAccount = new BankAccount()
        {
            OwnerName = "Maria",
            Amount = 500
        };

        IATMTransaction deposit = new DepositTransaction();
        IATMTransaction transfer = new TransferTransaction();
        IATMTransaction withdrawal = new WithdrawalTransaction();

        deposit.RequestDepositAmount(bankAccount, 150);
        transfer.RequestTransferAmount(bankAccount, 300);
        withdrawal.RequestWithdrawalAmount(bankAccount, 100);
        Console.WriteLine($"Ammount: {bankAccount.Amount}");
    }
}