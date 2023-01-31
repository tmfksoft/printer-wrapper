using System.Diagnostics;
using bpac;

class Program
{
    static void Main(string[] args)
    {
        string path = String.Join(" ", args);
        Console.WriteLine(path);
        bpac.DocumentClass doc = new DocumentClass();
        if (doc.Open(path) != false)
        {
            
            doc.StartPrint("", PrintOptionConstants.bpoDefault);
            Boolean res = doc.PrintOut(1, PrintOptionConstants.bpoDefault);
            if (!res)
            {
                doc.Close();
                System.Environment.Exit(doc.ErrorCode); // Forwards on the BPAC Error Code
            }
            doc.EndPrint();
            doc.Close();
        } else
        {
            System.Environment.Exit(doc.ErrorCode);
        }
    }
}