namespace ISP.Solved;

public interface ITranferTransaction
{
    void RequestTransferAmount(BankAccount bankAccount, double value); 
}