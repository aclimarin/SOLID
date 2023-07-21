using Runners.Initial;
using Runners.Solved;

public class Program
{
    private static void Main(string[] args)
    {

        #region SRP
        // IRunner initialSRP = new SRPInitialRunner();
        // initialSRP.Run();
        
        // IRunner solvedSRP = new SRPSolvedRunner();
        // solvedSRP.Run();
        #endregion

        #region OCP
        // IRunner initialOCP = new OCPInitialRunner();
        // initialOCP.Run();

        // IRunner solvedOCP = new OCPSolvedRunner();
        // solvedOCP.Run();
        #endregion

        #region LSP
        IRunner initialLSP = new LSPInitialRunner();
        initialLSP.Run();

        IRunner solvedLSP = new LSPSolvedRunner();
        solvedLSP.Run();
        #endregion

        #region ISP
        // IRunner initialISP = new ISPInitialRunner();
        // initialISP.Run();

        // IRunner solvedISP = new ISPSolvedRunner();
        // solvedISP.Run();
        #endregion

        #region DIP
        // IRunner initialDIP = new DIPInitialRunner();        
        // initialDIP.Run();

        // IRunner solvedDIP = new DIPSolvedRunner();        
        // solvedDIP.Run();
        #endregion
    }
}