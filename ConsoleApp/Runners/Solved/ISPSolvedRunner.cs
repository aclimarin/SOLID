using ISP.Solved;

namespace Runners.Solved;

public class ISPSolvedRunner : IRunner
{
    public void Run()
    {
        BankAccount bankAccount = new BankAccount()
        {
            OwnerName = "Maria",
            Amount = 500
        };

        IDepositTransaction deposit = new DepositTransaction();
        ITranferTransaction transfer = new TransferTransaction();
        IWithdrawalTransaction withdrawal = new WithdrawalTransaction();

        deposit.RequestDepositAmount(bankAccount, 150);
        transfer.RequestTransferAmount(bankAccount, 300);
        withdrawal.RequestWithdrawalAmount(bankAccount, 100);
        Console.WriteLine($"Ammount: {bankAccount.Amount}");
    }
}